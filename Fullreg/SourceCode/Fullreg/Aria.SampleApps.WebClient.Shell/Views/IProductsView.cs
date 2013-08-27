// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IProductsView.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Products View Interface
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aria.SampleApps.Common.Dto;

namespace Aria.SampleApps.WebClient.Shell.Views
{
    public interface IProductsView
    {
        Dictionary<string, string> LabelsList { get; set; }
        AccountCompleteDto AccountComplete { get; set; }
        List<ProductDto> ProductList { get; set; }
    }
}
