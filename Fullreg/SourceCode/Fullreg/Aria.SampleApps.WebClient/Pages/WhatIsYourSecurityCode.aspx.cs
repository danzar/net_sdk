// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WhatIsYourSecurityCode.aspx.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  What Is Your Security Code Page
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ARIA.Pages
{
    public partial class WhatIsYourSecurityCode : Page
    {

        /// <summary>
        /// Gets the labels list.
        /// </summary>
        /// <value>The labels list.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private Dictionary<string, string> LabelsList
        {
            get
            {
                return Cache["LabelsList"] == null ?
                    null : Cache["LabelsList"] as Dictionary<string, string>;
            }

        }

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
                if (LabelsList != null)
                {
                    whereiscvvLabel.Text = LabelsList["whereiscvv"];
                    whatiscvvLabel.Text = LabelsList["whatiscvv"];
                }
            }
        }
    }
}