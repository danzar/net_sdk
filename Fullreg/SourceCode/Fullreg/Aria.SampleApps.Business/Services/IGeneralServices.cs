// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IGeneralServices.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  General Services Interface
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aria.SampleApps.Common.Dto;
using Aria.SampleApps.Common.Enum;

namespace Aria.SampleApps.Business.Services
{
    public interface IGeneralServices
    {
        /// <summary>
        /// Gets the labels dictionary.
        /// </summary>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        Dictionary<string, string> GetLabelsDictionary();

        /// <summary>
        /// Gets the country list.
        /// </summary>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        Dictionary<string, string> GetCountryList();

        /// <summary>
        /// Gets the currency list.
        /// </summary>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        Dictionary<string, string> GetCurrencyList();

        /// <summary>
        /// Loads the plans by currency cd.
        /// </summary>
        /// <param name="currency">The currency.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        List<PlanDto> LoadPlansByCurrencyCd(string currency);

        /// <summary>
        /// Loads the plans by promo code.
        /// </summary>
        /// <param name="promoCode">The promo code.</param>
        /// <param name="currency">The currency.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        List<PlanDto> LoadPlansByPromoCode(string promoCode, string currency);

        /// <summary>
        /// Gets the supp plans list.
        /// </summary>
        /// <param name="planNo">The plan no.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        List<PlanDto> GetSuppPlansList(long planNo);

        /// <summary>
        /// Creates the account.
        /// </summary>
        /// <param name="accountCompleteDto">The account complete dto.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        long CreateAccount(AccountCompleteDto accountCompleteDto);


        /// <summary>
        /// Updates the billing information.
        /// </summary>
        /// <param name="accountCompleteDto">The account complete dto.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        void UpdateBillingInformation(AccountCompleteDto accountCompleteDto);

        /// <summary>
        /// Gets the product list by currency cd.
        /// </summary>
        /// <param name="currencyCd">The currency cd.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        List<ProductDto> GetProductListByCurrencyCd(string currencyCd);

        /// <summary>
        /// Gets the account details.
        /// </summary>
        /// <param name="currentAccountId">The current account id.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        AccountCompleteDto GetAccountDetails(long currentAccountId);

        /// <summary>
        /// Updates the account complete.
        /// </summary>
        /// <param name="accountCompleteDto">The account complete dto.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        void UpdateAccountComplete(AccountCompleteDto accountCompleteDto);

        /// <summary>
        /// Sets the session id.
        /// </summary>
        /// <param name="accountNo">The account no.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        string SetSessionId(long accountNo);

        /// <summary>
        /// Validates the session.
        /// </summary>
        /// <param name="sessionId">The session id.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        ValidateSessionDto ValidateSession(string sessionId);

        /// <summary>
        /// Users the id exsist.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        bool UserIdExsist(string userId);

        /// <summary>
        /// Updates the account status.
        /// </summary>
        /// <param name="accountNo">The account no.</param>
        /// <param name="status">The status.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        void UpdateAccountStatus(long accountNo, int status);
    }
}
