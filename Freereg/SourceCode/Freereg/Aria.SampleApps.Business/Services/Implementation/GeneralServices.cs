// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GeneralServices.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  General Services, This class connects to the service of aria and converts the responses of the methods 
//  in data transfer objects(dto) also converts the "data transfer objects" in requests that are sent to the services.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Aria.SampleApps.Common.Dto;
using Aria.SampleApps.Common.Enum;
using Aria.SampleApps.Common.Utils;
using Aria.SDK.AriaServices.AriaWebServices;
using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;
using Settings = Aria.SampleApps.Common.Configuration.SampleAppsSettings;

namespace Aria.SampleApps.Business.Services.Implementation
{
    public class GeneralServices : IGeneralServices
    {
        /// <summary>
        /// Validates the error.
        /// </summary>
        /// <param name="errorCode">The error code.</param>
        /// <param name="errorMessage">The error message.</param>
        /// <param name="methodName">Name of the method.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private static bool ValidateError(long errorCode, string errorMessage)
        {
            if (!string.IsNullOrEmpty(errorMessage) && errorMessage.ToUpper() != "OK")
            {
                Exception exp = new Exception("Error " + errorCode + ": " + errorMessage);
                var methodName = new StackFrame(1).GetMethod().Name;
                exp.Source = "Aria Service, Method:" + methodName;
                ErrorLog.SaveExceptionLog(exp);
                return true;
            }

            return false;
        }

        /// <summary>
        /// Gets the labels dictionary.
        /// </summary>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public Dictionary<string, string> GetLabelsDictionary()
        {
            var ariaServices = new AriaBillingComplete();

            var configParamRequest = new get_reg_uss_config_paramsRequest
                                        {
                                            auth_key = Settings.Default.auth_key,
                                            client_no = Settings.Default.client_no,
                                            set_name = Settings.Default.set_name
                                        };

            var response = ariaServices.get_reg_uss_config_params(configParamRequest);
            ValidateError(response.error_code, response.error_msg);
            
            var labelsList = from lables in response.out_reg_uss_config_params
                                     select new
                                     {
                                         value = lables.param_val,
                                         name = lables.param_name
                                     };

            return labelsList.OrderBy(l => l.value).ToDictionary(l => l.name, l => l.value);
        }

        /// <summary>
        /// Gets the country list.
        /// </summary>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public Dictionary<string, string> GetCountryList()
        {
            var ariaServices = new AriaBillingComplete();

            var clientRequest = new get_client_countriesRequest
                                    {
                                        auth_key = Settings.Default.auth_key,
                                        client_no = Settings.Default.client_no
                                    };

            var countriesResponse = ariaServices.get_client_countries(clientRequest);
            ValidateError(countriesResponse.error_code, countriesResponse.error_msg);

            var ret = from country in countriesResponse.client_country
                      select new
                      {
                          CountryCd = country.country_cd,
                          Name = country.country_english
                      };

            return ret.ToDictionary(c => c.CountryCd, c => c.Name);
        }

        /// <summary>
        /// Gets the currency list.
        /// </summary>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public Dictionary<string, string> GetCurrencyList()
        {
            var ariaServices = new AriaBillingComplete();
            var req = new get_client_currenciesRequest
                          {
                              auth_key = Settings.Default.auth_key,
                              client_no = Settings.Default.client_no
                          };

            var response = ariaServices.get_client_currencies(req);
            ValidateError(response.error_code, response.error_msg);

            var currencyList = from currency in response.client_currency
                             select new
                             {
                                 key = currency.currency_cd,
                                 value = currency.currency_cd.ToUpper() + " - " + currency.currency_name + " (" + currency.currency_symbol + ")"
                             };

            return currencyList.ToDictionary(l => l.key, l => l.value);
        }
       

        /// <summary>
        /// Users the id exsist.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public bool UserIdExsist(string userId)
        {
            var ariaServices = new AriaBillingComplete();

            var req = new userid_existsRequest
                          {
                              auth_key = Settings.Default.auth_key,
                              client_no = Settings.Default.client_no,
                              user_id = userId
                          };

            var res = ariaServices.userid_exists(req);

            if (res.error_code != 0 && res.error_code != 1009)
            {
                ValidateError(res.error_code, res.error_msg);
            }

            // Error code is zero if the user exists
            return res.error_code == 0;
        }

        /// <summary>
        /// Creates the account.
        /// </summary>
        /// <param name="accountCompleteDto">The account complete dto.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public long CreateAccount(AccountCompleteDto accountCompleteDto)
        {
            var ariaServices = new AriaBillingComplete();

            var newAccount = new create_acct_completeRequest
                                 {
                                     auth_key = Settings.Default.auth_key,
                                     client_no = Settings.Default.client_no,
                                     status_cd = (long)AccountStatusEnum.Active,
                                     do_full_invoicing = "false",
                                     do_prorated_invoicing = "false",
                                     first_name = accountCompleteDto.FirstName,
                                     last_name = accountCompleteDto.LastName,
                                     company_name = accountCompleteDto.CompanyName,
                                     password = accountCompleteDto.Password,
                                     secret_question = accountCompleteDto.SecurityQuestion,
                                     secret_question_answer = accountCompleteDto.Answer,
                                     userid = accountCompleteDto.UserId,
                                     address1 = accountCompleteDto.StreetAddress,
                                     address2 = accountCompleteDto.StreetAddress2,
                                     city = accountCompleteDto.CityTown,
                                     locality = accountCompleteDto.Locality,
                                     country = accountCompleteDto.Country,
                                     state_prov = accountCompleteDto.StateProvince,
                                     postal_cd = accountCompleteDto.ZipCode,
                                     phone = accountCompleteDto.PhoneNumber,
                                     email = accountCompleteDto.EmailAddress
                                 };

            if(accountCompleteDto.BillingInfo != null)
            {
                newAccount.bill_first_name = accountCompleteDto.BillingInfo.Name;
                newAccount.bill_last_name = accountCompleteDto.BillingInfo.LastName;
                newAccount.bill_country = accountCompleteDto.BillingInfo.Country;
                newAccount.bill_address1 = accountCompleteDto.BillingInfo.Address;
                newAccount.bill_address2 = accountCompleteDto.BillingInfo.Address2;
                newAccount.bill_city = accountCompleteDto.BillingInfo.CityTown;
                newAccount.bill_locality = accountCompleteDto.BillingInfo.Locality;
                newAccount.bill_postal_cd = accountCompleteDto.BillingInfo.ZipCode;
                newAccount.bill_phone = accountCompleteDto.BillingInfo.PhoneNumber;
                newAccount.bill_company_name = accountCompleteDto.BillingInfo.CompanyName;
                newAccount.bill_email = accountCompleteDto.BillingInfo.EmailAddress;
            }

            newAccount.master_plan_no = 10263679;
            newAccount.master_plan_units = 0;

            var response = ariaServices.create_acct_complete(newAccount);
            ValidateError(response.error_code, response.error_msg);
            var accNo = response.acct_no;

            return accNo;
        }

        /// <summary>
        /// Sets the session id, This method returns a value that will be loaded in the session
        /// </summary>
        /// <param name="accountNo">The account no.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public string SetSessionId(long accountNo)
        {
            var ariaServices = new AriaBillingComplete();

            var userIdReq = new get_user_id_from_acct_noRequest
                                {
                                    auth_key = Settings.Default.auth_key,
                                    client_no = Settings.Default.client_no,
                                    acct_no = accountNo
                                };

            var userIdResponse = ariaServices.get_user_id_from_acct_no(userIdReq);
            ValidateError(userIdResponse.error_code, userIdResponse.error_msg);

            var request = new set_sessionRequest
                              {
                                  auth_key = Settings.Default.auth_key,
                                  client_no = Settings.Default.client_no,
                                  user_id = userIdResponse.user_id
                              };

            var response = ariaServices.set_session(request);
            ValidateError(response.error_code, response.error_msg);

            return response.session_id;
        }

        /// <summary>
        /// Validates the session.
        /// </summary>
        /// <param name="sessionId">The session id.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public ValidateSessionDto ValidateSession(string sessionId)
        {
            var ariaServices = new AriaBillingComplete();

            var validateSessionRequest = new validate_sessionRequest()
                                             {
                                                 auth_key = Settings.Default.auth_key,
                                                 client_no = Settings.Default.client_no,
                                                 session_id = sessionId
                                             };

            var validateSessionResponse = ariaServices.validate_session(validateSessionRequest);
            ValidateError(validateSessionResponse.error_code, validateSessionResponse.error_msg);

            var ret = new ValidateSessionDto
                          {
                              AccountNo = validateSessionResponse.account_no,
                              UserId = validateSessionResponse.user_id,
                              ErrorCode = validateSessionResponse.error_code,
                              ErrorMessage = validateSessionResponse.error_msg,
                              // if error message is null then its a invalid session
                              ValidSession = validateSessionResponse.error_msg == null
                          };

            return ret;
        }
    }
}
