// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BillingInformationDto.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Billing Information Data transfer object
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
    public class BillingInformationDto
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Country{ get; set; }

        [DataMember]
        public string Address{ get; set; }

        [DataMember]
        public string Address2{ get; set; }

        [DataMember]
        public string CityTown{ get; set; }

        [DataMember]
        public string Locality { get; set; }

        [DataMember]
        public string ZipCode{ get; set; }

        [DataMember]
        public string PhoneNumber{ get; set; }

        [DataMember]
        public string CompanyName{ get; set; }

        [DataMember]
        public string EmailAddress{ get; set; }
    }
}
