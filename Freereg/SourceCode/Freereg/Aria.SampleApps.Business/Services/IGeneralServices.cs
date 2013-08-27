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
        /// Creates the account.
        /// </summary>
        /// <param name="accountCompleteDto">The account complete dto.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        long CreateAccount(AccountCompleteDto accountCompleteDto);

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
    }
}
