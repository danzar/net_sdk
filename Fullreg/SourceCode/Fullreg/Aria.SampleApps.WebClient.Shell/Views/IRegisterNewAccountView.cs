// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRegisterNewAccountView.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Register New Account View Interface
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using Aria.SampleApps.Common.Dto;

namespace Aria.SampleApps.WebClient.Shell.Views
{
    public interface IRegisterNewAccountView
    {
        Dictionary<string, string> LabelsList { get; set; }

        ValidateSessionDto ValidateSessionDto { get; set; }
        string SessionId { get; set; }

        //Account Info

        AccountCompleteDto AccountComplete { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string CompanyName { get; set; }

        string Password { get; set; }

        string Answer { get; set; }

        string UserId { get; set; }

        // Address Info

        string StreetAddress { get; set; }

        string StreetAddress2 { get; set; }

        string CityTown { get; set; }

        string Country { get; set; }

        Dictionary<string, string> CountryList { set; }

        string Locality { get; set; }

        string ZipCode { get; set; }

        // Contact Info

        string PhoneNumber { get; set; }

        string EmailAddress { get; set; }

        // Plan Info

        Dictionary<string, string> CurrencyList { set; }

        string Currency { get; set; }

        string CouponCode { get; set; }

        string PromoCode { get; set; }

        PlanDto SelectedMasterPlan { get; }

        List<PlanDto> SelectedSuppPlansList { get; }

        PlanDto EditMasterPlan { set; }

        List<PlanDto> EditSuppPlansList { set; }
    }
}
