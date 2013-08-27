// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReceiptPresenter.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Receipt Presenter
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
    public class ReceiptPresenter : Presenter<IReceiptView>
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
    }
}
