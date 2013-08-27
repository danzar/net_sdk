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
using Aria.SampleApps.Common.Enum;
using Aria.SampleApps.WebClient.Shell.Views;
using Microsoft.Practices.CompositeWeb;

namespace Aria.SampleApps.WebClient.Shell.Presenters
{
    public class ConfirmAccountInformationPresenter : Presenter<IConfirmAccountInformationView>
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
        /// Creates the acccount complete.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void CreateAcccountComplete()
        {
            var accNo = GeneralServices.CreateAccount(View.AccountCompleteDto);
            View.AccountCompleteDto.AccountNo = accNo;
            View.SessionId = GeneralServices.SetSessionId(accNo);
        }

        /// <summary>
        /// Suspends the account.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void SuspendAccount()
        {
            GeneralServices.UpdateAccountStatus(View.AccountCompleteDto.AccountNo, (int)AccountStatusEnum.Suspended);
        }
    }
}
