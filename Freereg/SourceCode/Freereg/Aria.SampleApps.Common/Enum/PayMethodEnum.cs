// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PayMethodEnum.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Pay Method Enum
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aria.SampleApps.Common.Enum
{
    public enum PayMethodEnum
    {
        CreditCard,
        ACH,
        Net0,
        Net10,
        Net15,
        Net30,
        Net45,
        Net60
    }
}
