// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IConfirmAccountInformationView.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Confirm Account Information View Interface
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Aria.SampleApps.Common.Dto;

namespace Aria.SampleApps.WebClient.Shell.Views
{
    public interface IConfirmAccountInformationView
    {
        Dictionary<string, string> LabelsList { get; set; }
        AccountCompleteDto AccountCompleteDto { get; set; }
        ValidateSessionDto ValidateSessionDto { get; set; }
        string SessionId { get; set; }
    }
}
