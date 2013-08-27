// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductDto.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Product Data transfer object
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
    public class ProductDto
    {
        [DataMember]
        public string ClientSku { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
