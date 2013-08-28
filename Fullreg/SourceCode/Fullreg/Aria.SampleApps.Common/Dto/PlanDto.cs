// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlanDto.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Plan Data transfer object
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
    public class PlanDto
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public double Price { get; set; }

        [DataMember]
        public string CurrencyCd { get; set; }

        [DataMember]
        public string CurrencySymbol { get; set; }

        [DataMember]
        public long Interval { get; set; }

        [DataMember]
        public string IntervalName { get; set; }

        [DataMember]
        public long Units { get; set; }

        [DataMember]
        public List<PlanDto> ServiceList { get; set; }

        [DataMember]
        public bool MasterPlan { get; set; }

    }
}
