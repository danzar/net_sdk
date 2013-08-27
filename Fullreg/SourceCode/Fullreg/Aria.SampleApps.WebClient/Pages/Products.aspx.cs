// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Products.aspx.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
// Products Page
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aria.SampleApps.Common.Dto;
using Aria.SampleApps.Common.Enum;
using Aria.SampleApps.Common.Web;
using Aria.SampleApps.WebClient.Shell.Presenters;
using Aria.SampleApps.WebClient.Shell.Views;

namespace ARIA.Pages
{
    public partial class Products :
        MvpBasePage<ProductsPresenter, IProductsView>, IProductsView
    {
        #region Properties

        /// <summary>
        /// Gets or sets the labels list.
        /// </summary>
        /// <value>The labels list.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public Dictionary<string, string> LabelsList
        {
            get
            {
                return Cache["LabelsList"] == null ?
                    null : Cache["LabelsList"] as Dictionary<string, string>;
            }
            set
            {
                Cache["LabelsList"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the account complete.
        /// </summary>
        /// <value>The account complete.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public AccountCompleteDto AccountComplete
        {
            get
            {
                return ViewState["AccountComplete"] as AccountCompleteDto;
            }
            set
            {
                ViewState["AccountComplete"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the product list.
        /// </summary>
        /// <value>The product list.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public List<ProductDto> ProductList
        {
            get
            {
                if (ViewState["ProductList"] != null)
                {
                    return ViewState["ProductList"] as List<ProductDto>;
                }

                return new List<ProductDto>();
            }
            set
            {
                ViewState["ProductList"] = value;
            }
        }

        /// <summary>
        /// Gets the selected product list.
        /// </summary>
        /// <value>The selected product list.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private Dictionary<string , long> SelectedProductList
        {
            get
            {
                var retList = new Dictionary<string, long>();

                foreach (GridViewRow row in productsGridView.Rows)
                {
                    TextBox unitsTexBox = (TextBox)row.FindControl("unitsTexBox");
                    HiddenField prodIdHiddenField = (HiddenField)row.FindControl("prodIdHiddenField");

                    if (!string.IsNullOrEmpty(unitsTexBox.Text))
                    {
                        retList.Add(prodIdHiddenField.Value, long.Parse(unitsTexBox.Text));
                    }
                }

                return retList;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["AccountComplete"] != null)
                {
                    AccountComplete = Session["AccountComplete"] as AccountCompleteDto;
                    Session["AccountComplete"] = null;
                }
                else
                {
                    MoveBackward(ARIASDKPages.CreateAccount);
                }

                if (LabelsList != null)
                {
                    LoadLabelsText();
                }

                presenter.LoadProductList();
                productsGridView.DataSource = ProductList;
                productsGridView.DataBind();
            }
        }

        /// <summary>
        /// Loads the labels text.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private void LoadLabelsText()
        {
            selectproductsLabel.Text = LabelsList["selectproducts"];
            checkproductsLabel.Text = LabelsList["checkproducts"];
        }

        /// <summary>
        /// Handles the Click event of the BackButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void BackButton_Click(object sender, EventArgs e)
        {
            Session["AccountComplete"] = AccountComplete;
            MoveBackward(ARIASDKPages.BillingInfo);
        }

        /// <summary>
        /// Handles the Click event of the NextButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void NextButton_Click(object sender, EventArgs e)
        {
            AccountComplete.ProductList = SelectedProductList.Count > 0 ? SelectedProductList : null;
            Session["AccountComplete"] = AccountComplete;
            MoveForward();
        }

        #endregion
    }
}
