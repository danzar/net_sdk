// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BillingInformationPresenter.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Billing Information Presenter
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Data;
using Aria.SampleApps.Business.Services;
using Aria.SampleApps.Common.Dto;
using Aria.SampleApps.WebClient.Shell.Views;
using Microsoft.Practices.CompositeWeb;

namespace Aria.SampleApps.WebClient.Shell.Presenters
{
    public class BillingInformationPresenter : Presenter<IBillingInformationView>
    {
        public IGeneralServices GeneralServices { get; set; }
        
        /// <summary>
        /// Validates the session.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void ValidateSession()
        {
            View.ValidateSessionDto = GeneralServices.ValidateSession(View.SessionId);
        }

        /// <summary>
        /// Creates the account.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void UpdateBillingInformation()
        {
            GeneralServices.UpdateBillingInformation(View.AccountComplete);
        }

        /// <summary>
        /// Loads the drop down lists.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void LoadDropDownLists()
        {
            View.CountryList = GeneralServices.GetCountryList();
        }
    }
}
