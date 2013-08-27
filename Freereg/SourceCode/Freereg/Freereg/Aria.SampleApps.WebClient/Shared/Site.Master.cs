// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Site.Master.cs" company="INS">
//    Copyright (c) Sivicap 2010. All rights reserved. 
// </copyright>
// <author>Esteban Diaz</author>
// <summary>
//   Master Page.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Aria.SampleApps.Common.Web;
using Aria.SampleApps.WebClient.Shell.Presenters;
using Aria.SampleApps.WebClient.Shell.Views;

namespace ARIA.Shared
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Web;

    /// <summary>
    /// Master Page
    /// </summary>
    /// <Author>Esteban Diaz</Author>
    public partial class Site : System.Web.UI.MasterPage
        //MvpMasterBasePage<MasterPresenter, IMasterView>, IMasterView
            
    {
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
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <Author>Esteban Diaz</Author>
        protected void Page_Load(object sender, EventArgs e)
        {
            PreRender += new EventHandler(Site_PreRender);
        }

        /// <summary>
        /// Handles the PreRender event of the Site control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="E">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        void Site_PreRender(object sender, EventArgs E)
        {
            universalFooterLabel.Text = LabelsList["universalfooter"];
            signinLabel.Text = LabelsList["signin"];
        }
    }
}
