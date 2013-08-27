// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidateSessionDto.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Validate Session Data transfer object
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
    public class ValidateSessionDto
    {
        [DataMember]
        public long AccountNo { get; set; }

        [DataMember]
        public string UserId { get; set; }

        [DataMember]
        public long ErrorCode { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }

        [DataMember]
        public bool ValidSession { get; set; }
    }
}
