// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseUserControl.cs" company="INS">
//    Copyright (c) Sivicap 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez usuga</author>
// <summary>
//   Base User Control.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Web.UI;

namespace Aria.SampleApps.Common.Web
{
    /// <summary>
    /// Base Clase for all the user controls in Genesis Project.
    /// </summary>
    public class BaseUserControl : UserControl
    {
        /// <summary>
        /// Gets the base page.
        /// </summary>
        /// <value>The base page.</value>
        public BasePage BasePage
        {
            get
            {
                return Page as BasePage;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value><c>true</c> if this instance is active; otherwise, <c>false</c>.</value>
        public virtual bool IsActive
        {
            get
            {
                if (ViewState["IsActive"] == null)
                {
                    ViewState["IsActive"] = false;
                }

                return (bool)ViewState["IsActive"];
            }

            set
            {
                ViewState["IsActive"] = value;
            }
        }
    }
}
