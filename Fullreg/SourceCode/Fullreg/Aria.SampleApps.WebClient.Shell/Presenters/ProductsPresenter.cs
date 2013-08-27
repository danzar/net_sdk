// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ProductsPresenter.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Products Presenter
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aria.SampleApps.Business.Services;
using Aria.SampleApps.WebClient.Shell.Views;
using Microsoft.Practices.CompositeWeb;

namespace Aria.SampleApps.WebClient.Shell.Presenters
{
    public class ProductsPresenter : Presenter<IProductsView>
    {
        /// <summary>
        /// Gets or sets the general services.
        /// </summary>
        /// <value>The general services.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public IGeneralServices GeneralServices { get; set; }

        /// <summary>
        /// Loads the plans list.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void LoadProductList()
        {
            View.ProductList = GeneralServices.GetProductListByCurrencyCd(View.AccountComplete.Currency);
        }
    }
}
