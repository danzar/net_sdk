// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreditCardDto.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Credit Card Data transfer object
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
    public class CreditCardDto
    {
        [DataMember]
        public long Number { get; set; }

        [DataMember]
        public int ExpireMonth { get; set; }

        [DataMember]
        public int ExpireYear { get; set; }

        [DataMember]
        public long SecurityCode { get; set; }
    }
}
