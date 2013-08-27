// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreditCardTypeEnum.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Credit Card Type Enum
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aria.SampleApps.Common.Enum
{
    public enum CreditCardTypeEnum
    {
       INVALID = -1,
       VISA = 0,
       MASTERCARD = 1,
       AMERICAN_EXPRESS = 2,
       EN_ROUTE = 3,
       DINERS_CLUB = 4
    }
}
