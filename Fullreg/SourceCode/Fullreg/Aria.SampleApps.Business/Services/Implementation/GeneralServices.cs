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
        /// Loads the plans by currency cd.
        /// </summary>
        /// <param name="currencyCd">The currency cd.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public List<PlanDto> LoadPlansByCurrencyCd(string currencyCd)
        {
            var ariaServices = new AriaBillingComplete();

            var plansRequest = new get_client_plans_allRequest
                                {
                                    auth_key = Settings.Default.auth_key,
                                    client_no = Settings.Default.client_no
                                };

            var response = ariaServices.get_client_plans_all(plansRequest);
            ValidateError(response.error_code, response.error_msg);

            var ret = from plans in response.all_client_plans
                      where plans.currency_cd == currencyCd  
                      select new PlanDto
                      {
                          Id = plans.plan_no,
                          Name = plans.plan_name,
                          Description = plans.plan_desc,
                          CurrencySymbol = Utils.GetCurrencySymbolByIsoCurrencySymbol(plans.currency_cd),
                          Price = plans.plan_services != null ? plans.plan_services.Sum(
                                     s => s.plan_service_rates != null ? s.plan_service_rates.FirstOrDefault().rate_per_unit : 0) : 0,
                          CurrencyCd = plans.currency_cd.ToUpper(),
                          Interval = plans.billing_interval,
                          ServiceList = plans.plan_services != null ? plans.plan_services
                                     .Select(s => new PlanDto()
                                     {
                                         Description = s.service_desc,
                                         CurrencySymbol = Utils.GetCurrencySymbolByIsoCurrencySymbol(plans.currency_cd),
                                         Price = s.plan_service_rates != null ? s.plan_service_rates.FirstOrDefault().rate_per_unit : 0,
                                         CurrencyCd = plans.currency_cd.ToUpper(),
                                         Interval = plans.billing_interval
                                     }).ToList()
                                         : new List<PlanDto>()
                      };

            return ret.ToList();
        }

        /// <summary>
        /// Loads the plans by promo code.
        /// </summary>
        /// <param name="promoCode">The promo code.</param>
        /// <param name="currencyCd">The currency cd.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public List<PlanDto> LoadPlansByPromoCode(string promoCode, string currencyCd)
        {
            var ariaServices = new AriaBillingComplete();

            var plansRequest = new get_plans_by_promo_codeRequest
                                {
                                    auth_key = Settings.Default.auth_key,
                                    client_no = Settings.Default.client_no,
                                    promo_code = promoCode
                                };

            var response = ariaServices.get_plans_by_promo_code(plansRequest);
            ValidateError(response.error_code, response.error_msg);

            var promoCodePlans = from plans in response.plans
                                  select new PlanDto
                                  {
                                      Id = plans.plan_no
                                  };

            // I must make this because the method Get plans by promo code don't return all the neccesary fields
            var planList = LoadPlansByCurrencyCd(currencyCd);
            var ret = new List<PlanDto>();

            foreach (var planDto in promoCodePlans)
            {
                var promoCodePlan = planList.Where(p => p.Id == planDto.Id).FirstOrDefault();
                if (promoCodePlan != null)
                {
                    ret.Add(promoCodePlan);
                }
            }

            return ret.ToList();
        }

        /// <summary>
        /// Gets the supp plans list.
        /// </summary>
        /// <param name="planNo">The plan no.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public List<PlanDto> GetSuppPlansList(long planNo)
        {
            var ariaServices = new AriaBillingComplete();

            var plansRequest = new get_avail_child_plans_for_planRequest
                                   {
                                       auth_key = Settings.Default.auth_key,
                                       client_no = Settings.Default.client_no,
                                       in_plan_no = planNo
                                   };

            var response = ariaServices.get_avail_child_plans_for_plan(plansRequest);
            ValidateError(response.error_code, response.error_msg);

            var ret = from plans in response.plans
                      select new PlanDto
                                 {
                                     Id = plans.plan_no,
                                     Name = plans.plan_name,
                                     Description = plans.plan_desc,
                                     CurrencySymbol =
                                         Utils.GetCurrencySymbolByIsoCurrencySymbol(plans.currency_cd),
                                     CurrencyCd = plans.currency_cd.ToUpper(),
                                     Interval = plans.billing_interval
                                 };

            return ret.ToList();
        }

        /// <summary>
        /// Gets the product list by currency cd.
        /// </summary>
        /// <param name="currencyCd">The currency cd.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public List<ProductDto> GetProductListByCurrencyCd(string currencyCd)
        {
            var ariaServices = new AriaBillingComplete();

            var clientItemsRequest = new get_client_itemsRequest
                                         {
                                             auth_key = Settings.Default.auth_key,
                                             client_no = Settings.Default.client_no,
                                             filter_currency_cd = currencyCd
                                         };

            var response = ariaServices.get_client_items(clientItemsRequest);
            ValidateError(response.error_code, response.error_msg);

            var retList = from prod in response.client_items
                          select new ProductDto
                          {
                              ClientSku = prod.client_sku,
                              Name = prod.item_label
                          };

            return retList.ToList();
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

            if(accountCompleteDto.MasterPlan != null)
            {
                // If the account contains all the plan data then add to create_acct_completeRequest the plan data
                var couponCodesList = new List<coupon_codes_row>();
                couponCodesList.Add(new coupon_codes_row { coupon_codes = accountCompleteDto.CouponCode });
                var couponCodesArray = couponCodesList.ToArray();

                var suppPlansArray = (from suppPlans in accountCompleteDto.SupplementalPlans
                                      select new supp_plans_row { supp_plans = suppPlans.Id, }).ToArray();
                var suppPlansUnitsArray = (from suppPlans in accountCompleteDto.SupplementalPlans
                                           select new supp_plan_units_row { supp_plan_units = suppPlans.Units == null ? 0 : suppPlans.Units.Value }).ToArray();

                newAccount.currency_cd = accountCompleteDto.Currency;
                newAccount.promo_cd = accountCompleteDto.PromoCode;
                newAccount.master_plan_no = accountCompleteDto.MasterPlan.Id;
                newAccount.master_plan_units = accountCompleteDto.MasterPlan.Units;
                newAccount.supp_plans = suppPlansArray;
                newAccount.supp_plan_units = suppPlansUnitsArray;
            }
            else
            {
                // if master plan isn't selected
                newAccount.master_plan_no = 10263679;
                newAccount.master_plan_units = 0;
            }

            var response = ariaServices.create_acct_complete(newAccount);
            ValidateError(response.error_code, response.error_msg);
            var accNo = response.acct_no;

            if (accountCompleteDto.ProductList != null && accountCompleteDto.ProductList.Count > 0)
            {
                // If select products, then create the "order request"
                var createOrderRequestResponse = CreateOrderRequest(accountCompleteDto.ProductList, accNo);
                ValidateError(createOrderRequestResponse.error_code, createOrderRequestResponse.error_msg);
            }

            if (accountCompleteDto.MasterPlan != null)
            {
                // If select master plan, then gen the invoice
                var genInvoiceResponse = GenInvoice(accNo);
                ValidateError(genInvoiceResponse.error_code, genInvoiceResponse.error_msg);
            }

            return accNo;
        }

        /// <summary>
        /// Creates the order request.
        /// </summary>
        /// <param name="selectedProductList">The selected product list.</param>
        /// <param name="accountNo">The account no.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private create_orderResponse CreateOrderRequest(Dictionary<string, long> selectedProductList, long accountNo)
        {
            var ariaServices = new AriaBillingComplete();

            var productList = (from product in selectedProductList
                              select new order_line_items_row
                                         {
                                             client_sku = product.Key,
                                             units = product.Value
                                         }).ToArray();

            var itemsRequest = new create_orderRequest
                                   {
                                       auth_key = Settings.Default.auth_key,
                                       client_no = Settings.Default.client_no,
                                       account_no = accountNo,
                                       order_line_items = productList
                                   };

            var response = ariaServices.create_order(itemsRequest);
            return response;
        }

        /// <summary>
        /// Gens the invoice.
        /// </summary>
        /// <param name="accountNo">The account no.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private gen_invoiceResponse GenInvoice(long accountNo)
        {
            var ariaServices = new AriaBillingComplete();
            var genInvoiceRequest = new gen_invoiceRequest
                                        {
                                            auth_key = Settings.Default.auth_key,
                                            client_no = Settings.Default.client_no,
                                            force_pending = "true",
                                            acct_no = accountNo
                                        };

            var response = ariaServices.gen_invoice(genInvoiceRequest);
            return response;
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
    
        /// <summary>
        /// Gets the account details.
        /// </summary>
        /// <param name="currentAccountId">The current account id.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        /// 
        /// ***************** At moment this method is never used!!!!!!!!!!!!!!!!*********************
        public AccountCompleteDto GetAccountDetails(long currentAccountId)
        {
            var ariaServices = new AriaBillingComplete();

            var accRequest = new get_acct_details_allRequest
                                 {
                                     auth_key = Settings.Default.auth_key,
                                     client_no = Settings.Default.client_no,
                                     acct_no = currentAccountId
                                 };

            var accPlansRequest = new get_acct_plansRequest
                                      {
                                          auth_key = Settings.Default.auth_key,
                                          client_no = Settings.Default.client_no,
                                          acct_no = currentAccountId
                                      };

            var accDetailsResponse = ariaServices.get_acct_details_all(accRequest);
            ValidateError(accDetailsResponse.error_code, accDetailsResponse.error_msg);
            var accountPlansResponse = ariaServices.get_acct_plans(accPlansRequest);
            ValidateError(accountPlansResponse.error_code, accountPlansResponse.error_msg);

            var billingInfo = new BillingInformationDto
                                  {
                                      Name =
                                          accDetailsResponse.billing_first_name + " " +
                                          accDetailsResponse.billing_last_name,
                                      CompanyName = accDetailsResponse.billing_company_name,
                                      Address = accDetailsResponse.billing_address1,
                                      Address2 = accDetailsResponse.billing_address2,
                                      CityTown = accDetailsResponse.billing_city,
                                      Locality = accDetailsResponse.billing_state,
                                      ZipCode = accDetailsResponse.billing_zip,
                                      PhoneNumber = accDetailsResponse.billing_intl_phone,
                                      EmailAddress = accDetailsResponse.billing_email
                                  };

            var masterPlan = accountPlansResponse.acct_plans.
                Where(p => p.plan_no == long.Parse(accDetailsResponse.plan_no)).FirstOrDefault();

            var masterPlanDto = new PlanDto
                                    {
                                        Id = masterPlan.plan_no,
                                        Name = masterPlan.plan_name,
                                        Description = masterPlan.plan_desc,
                                        Units = masterPlan.plan_units,
                                        Price = 5 // How can I get the plan price??????
                                    };

            var suppPlans = from plans in accountPlansResponse.acct_plans
                            where plans.plan_no != long.Parse(accDetailsResponse.plan_no)
                            select new PlanDto
                                        {
                                            Id = plans.plan_no,
                                            Name = plans.plan_name,
                                            Description = plans.plan_desc,
                                            Units = plans.plan_units,
                                            Price = 5 // How can I get the plan price??????
                                        };

            var accountComplete = new AccountCompleteDto
                                      {
                                          FirstName = accDetailsResponse.first_name,
                                          LastName = accDetailsResponse.last_name,
                                          CompanyName = accDetailsResponse.company_name,
                                          StreetAddress = accDetailsResponse.address1,
                                          StreetAddress2 = accDetailsResponse.address2,
                                          CityTown = accDetailsResponse.city,
                                          Locality = accDetailsResponse.locality,
                                          Country = accDetailsResponse.country,
                                          ZipCode = accDetailsResponse.postal_code,
                                          PhoneNumber = accDetailsResponse.intl_phone,
                                          EmailAddress = accDetailsResponse.notify_method,
                                          UserId = accDetailsResponse.userid,
                                          Password = accDetailsResponse.PASSWORD,
                                          SecurityQuestion = accDetailsResponse.secret_question,
                                          Answer = accDetailsResponse.secret_question_answer,
                                          BillingInfo = billingInfo,
                                          MasterPlan = masterPlanDto,
                                          SupplementalPlans = suppPlans.ToList()
                                      };

            return accountComplete;
        }

        /// <summary>
        /// Updates the account complete.
        /// </summary>
        /// <param name="accountCompleteDto"></param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void UpdateAccountComplete(AccountCompleteDto accountCompleteDto)
        {
            var ariaServices = new AriaBillingComplete();

            var newAccount = new update_acct_completeRequest()
                                 {
                                     auth_key = Settings.Default.auth_key,
                                     client_no = Settings.Default.client_no,
                                     acct_no = accountCompleteDto.AccountNo,
                                     first_name = accountCompleteDto.FirstName,
                                     last_name = accountCompleteDto.LastName,
                                     company_name = accountCompleteDto.CompanyName,
                                     password = accountCompleteDto.Password,
                                     secret_question = accountCompleteDto.SecurityQuestion,
                                     secret_question_answer = accountCompleteDto.Answer,
                                     address1 = accountCompleteDto.StreetAddress,
                                     address2 = accountCompleteDto.StreetAddress2,
                                     city = accountCompleteDto.CityTown,
                                     locality = accountCompleteDto.Locality,
                                     country = accountCompleteDto.Country,
                                     state_prov = accountCompleteDto.StateProvince,
                                     postal_cd = accountCompleteDto.ZipCode,
                                     phone = accountCompleteDto.PhoneNumber,
                                     email = accountCompleteDto.EmailAddress,
                                 };

            //Any change of plans or order items should trigger a ‘manage_pending_invoice’ to discard the existing pending invoice. 
            //A new pending invoice will need to be created with ‘gen_invoice’.
            var managePedingInvoiceResponse = ManagePendingInvoice(accountCompleteDto.AccountNo, (long)InvoiceDirectiveEnum.Discard);
            ValidateError(managePedingInvoiceResponse.error_code, managePedingInvoiceResponse.error_msg);
            var genInvoiceRequest = GenInvoice(accountCompleteDto.AccountNo);
            ValidateError(genInvoiceRequest.error_code, genInvoiceRequest.error_msg);

            //Change of master plan should be accomplished via ‘update_master_plan’ with “auto_cancel_supp_plans” true, 
            //and then reassigning supplemental plans with assign_supp_plan_multi.
            var updateMasterPlanRequest = new update_master_planRequest
                                              {
                                                  auth_key = Settings.Default.auth_key,
                                                  client_no = Settings.Default.client_no,
                                                  acct_no = accountCompleteDto.AccountNo,
                                                  auto_cancel_supp_plans = "true",
                                                  master_plan_no = accountCompleteDto.MasterPlan.Id,
                                                  num_plan_units = accountCompleteDto.MasterPlan.Units == null ? 0 : accountCompleteDto.MasterPlan.Units.Value

                                              };

            var suppPlansList = (from suppPlans in accountCompleteDto.SupplementalPlans
                                 select new supp_plans_to_assign_row
                                             {
                                                 supp_plan_no = suppPlans.Id,
                                                 num_plan_units = suppPlans.Units == null ? 0 : suppPlans.Units.Value
                                             }).ToArray();

            var updateSuppPlansRequest = new assign_supp_plan_multiRequest
                                             {
                                                 auth_key = Settings.Default.auth_key,
                                                 client_no = Settings.Default.client_no,
                                                 acct_no = accountCompleteDto.AccountNo,
                                                 supp_plans_to_assign = suppPlansList
                                             };

            var updateMasterPlanResponse = ariaServices.update_master_plan(updateMasterPlanRequest);
            ValidateError(updateMasterPlanResponse.error_code, updateMasterPlanResponse.error_msg);
            var updateSuppPlansResponse = ariaServices.assign_supp_plan_multi(updateSuppPlansRequest);
            ValidateError(updateSuppPlansResponse.error_code, updateSuppPlansResponse.error_msg);
            var updateAccCompleteResponse = ariaServices.update_acct_complete(newAccount);
            ValidateError(updateAccCompleteResponse.error_code, updateAccCompleteResponse.error_msg);
        }

        /// <summary>
        /// Manages the pending invoice.
        /// </summary>
        /// <param name="accountNo">The account no.</param>
        /// <param name="directive">The directive.</param>
        ///    1 Approve pending invoice.
        ///    2 Discard pending invoice.
        ///    3 Regenerate pending invoice.
        /// <author>Hector Fabio Gómez Usuga.</author>
        private manage_pending_invoiceResponse ManagePendingInvoice(long accountNo, long directive)
        {
            var ariaServices = new AriaBillingComplete();

            var pendingInvoiceRequest = new get_pending_invoice_noRequest
                                            {
                                                auth_key = Settings.Default.auth_key,
                                                client_no = Settings.Default.client_no,
                                                acct_no = accountNo
                                            };

            var pendingInvoiceResponse = ariaServices.get_pending_invoice_no(pendingInvoiceRequest);
            ValidateError(pendingInvoiceResponse.error_code, pendingInvoiceResponse.error_msg);
            var invoiceNo = pendingInvoiceResponse.invoice_no;

            var managePendingInvoiceRequest = new manage_pending_invoiceRequest
                                                  {
                                                      auth_key = Settings.Default.auth_key,
                                                      client_no = Settings.Default.client_no,
                                                      acct_no = accountNo,
                                                      invoice_no = invoiceNo,
                                                      action_directive = directive
                                                  };

            var response = ariaServices.manage_pending_invoice(managePendingInvoiceRequest);
            return response;
        }

        /// <summary>
        /// Updates the billing information.
        /// </summary>
        /// <param name="accountComplete">The account complete.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void UpdateBillingInformation(AccountCompleteDto accountComplete)
        {
            var billingInfoDto = accountComplete.BillingInfo;
            var ariaServices = new AriaBillingComplete();

            var updateAccRequest = new update_acct_billing_contactRequest
                                       {
                                           auth_key = Settings.Default.auth_key,
                                           client_no = Settings.Default.client_no,
                                           account_no = accountComplete.AccountNo,
                                           first_name = billingInfoDto.Name,
                                           last_name = billingInfoDto.LastName,
                                           country = billingInfoDto.Country,
                                           address1 = billingInfoDto.Address,
                                           address2 = billingInfoDto.Address2,
                                           city = billingInfoDto.CityTown,
                                           locality = billingInfoDto.Locality,
                                           zip = billingInfoDto.ZipCode,
                                           intl_phone = billingInfoDto.PhoneNumber,
                                           company_name = billingInfoDto.CompanyName,
                                           email = billingInfoDto.EmailAddress
                                       };

            var response = ariaServices.update_acct_billing_contact(updateAccRequest);
            ValidateError(response.error_code, response.error_msg);
        }

        /// <summary>
        /// Updates the account status.
        /// </summary>
        /// <param name="accountNo">The account no.</param>
        /// <param name="status">The status.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void UpdateAccountStatus(long accountNo, int status)
        {
            var ariaServices = new AriaBillingComplete();

            var req = new update_acct_statusRequest
                          {
                              auth_key = Settings.Default.auth_key,
                              client_no = Settings.Default.client_no,
                              account_no = accountNo,
                              status_cd = status
                          };

            var response = ariaServices.update_acct_status(req);
            ValidateError(response.error_code, response.error_msg);
        }
    }
}
