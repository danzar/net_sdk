// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InvoiceDirectiveEnum.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Invoice Directive Enum
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aria.SampleApps.Common.Enum
{
    ///    1 Approve pending invoice.
    ///    2 Discard pending invoice.
    ///    3 Regenerate pending invoice.
    public enum InvoiceDirectiveEnum
    {
        Aprove = 1,
        Discard = 2,
        Regenerate = 3
    }
}
