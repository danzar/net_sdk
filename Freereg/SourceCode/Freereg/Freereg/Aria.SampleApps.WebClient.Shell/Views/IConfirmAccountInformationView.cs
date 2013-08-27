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
        AccountCompleteDto AccountCompleteDto { get; set; }
    }
}
