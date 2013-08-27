// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfirmAccountInformationPresenter.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Confirm Account Information Presenter
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
    public class ConfirmAccountInformationPresenter : Presenter<IConfirmAccountInformationView>
    {
        public IGeneralServices GeneralServices { get; set; }
        
        /// <summary>
        /// Creates the acccount complete.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void CreateAcccountComplete()
        {
            GeneralServices.CreateAccount(View.AccountCompleteDto);
        }
    }
}
