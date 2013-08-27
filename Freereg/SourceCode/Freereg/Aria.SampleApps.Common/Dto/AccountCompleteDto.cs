// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AccountCompleteDto.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Account Complete Data transfer object
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Aria.SampleApps.Common.Dto
{
    [DataContract]
    [Serializable]
    public class AccountCompleteDto
    {
        // General Account Info
        [DataMember]
        public long AccountNo { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string CompanyName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string SecurityQuestion { get; set; }

        [DataMember]
        public string Answer { get; set; }

        [DataMember]
        public string UserId { get; set; }

        //Billing Info
        [DataMember]
        public BillingInformationDto BillingInfo { get; set; }

        // Address Info
        [DataMember]
        public string StreetAddress { get; set; }

        [DataMember]
        public string StreetAddress2 { get; set; }

        [DataMember]
        public string CityTown { get; set; }

        [DataMember]
        public string Locality { get; set; }

        [DataMember]
        public string Country { get; set; }

        [DataMember]
        public string StateProvince { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

        // Contact Info
        [DataMember]
        public string PhoneNumber { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }

        // Plan Info
        [DataMember]
        public string Currency { get; set; }

        [DataMember]
        public string CouponCode { get; set; }

        [DataMember]
        public string PromoCode { get; set; }

        [DataMember]
        public PlanDto MasterPlan { get; set; }

        [DataMember]
        public List<PlanDto> SupplementalPlans { get; set; }

        [DataMember]
        public Dictionary<string, long> ProductList { get; set; }
    }
}
