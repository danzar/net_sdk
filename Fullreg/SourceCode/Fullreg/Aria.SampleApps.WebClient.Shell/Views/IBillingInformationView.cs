// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBillingInformationView.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Billing Information View Interface
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Aria.SampleApps.Common.Dto;

namespace Aria.SampleApps.WebClient.Shell.Views
{
    public interface IBillingInformationView
    {
        Dictionary<string, string> LabelsList { get; set; }

        Dictionary<string, string> CountryList { set; }

        ValidateSessionDto ValidateSessionDto { get; set; }

        string SessionId { get; set; }

        //long CurrentAccountId { get; set; }

        AccountCompleteDto AccountComplete { get; set; }

        string Name { get; set; }

        string Country { get; set; }

        string Adress { get; set; }

        string Adress2 { get; set; }

        string CityTown { get; set; }

        string Locality { get; set; }

        string ZipCode { get; set; }

        string PhoneNumber { get; set; }

        string CompanyName { get; set; }

        string EmailAddress { get; set; }
    }
}
