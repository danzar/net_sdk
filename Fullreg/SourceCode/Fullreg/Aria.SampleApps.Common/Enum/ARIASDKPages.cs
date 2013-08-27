// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ARIASDKPages.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  ARIA SDK Pages
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Aria.SampleApps.Common.Enum
{
    public enum ARIASDKPages
    {
        [Description("")]
        Next = 0,
        [Description("RegisterNewAccount.aspx")]
        CreateAccount = 1,
        [Description("BillingInformation.aspx")]
        BillingInfo = 2,
        [Description("Products.aspx")]
        Products = 3,
        [Description("ConfirmAccountInformation.aspx")]
        Confirm = 4,
        [Description("PaymentInfo.aspx")]
        Payment = 5,
        [Description("Receipt.aspx")]
        Receipt = 6
    }
}
