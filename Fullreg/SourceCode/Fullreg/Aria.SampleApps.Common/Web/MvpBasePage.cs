// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MvpBasePage.cs" company="INS">
//    Copyright (c) Sivicap 2010. All rights reserved. 
// </copyright>
// <author>Esteban Diaz</author>
// <summary>
//   Base Class for all the mvp pages.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Web.UI;
using Microsoft.Practices.CompositeWeb;

namespace Aria.SampleApps.Common.Web
{
    /// <summary>
    /// Base Class for all the mvp pages.
    /// </summary>
    /// <typeparam name="TPresenter">The type of the presenter.</typeparam>
    /// <typeparam name="TView">The type of the view.</typeparam>
    public class MvpBasePage<TPresenter, TView> : BasePage
        where TPresenter : Presenter<TView>
        where TView : class
    {

        #region Mvp configuration

        protected TPresenter Presenter;

        /// <summary>
        /// Gets or sets the presenter.
        /// </summary>
        /// <value>The presenter.</value>
        /// <author>Esteban Diaz</author>
        public TPresenter presenter
        {
            get
            {
                return this.Presenter;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                this.Presenter = value;
                this.Presenter.View = this as TView;
            }
        }

        public MvpBasePage()
        {
            Load += MvpBasePageLoad;
        }

        /// <summary>
        /// MVPs the base page load.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Víctor Manuel Velásquez C.</author>
        private void MvpBasePageLoad(object sender, EventArgs e)
        {
            var scriptManager = ScriptManager.GetCurrent(this);

            var isAsyc = scriptManager != null && scriptManager.IsInAsyncPostBack;

            if (!(IsPostBack || isAsyc))
            {
                presenter.OnViewInitialized();
            }

            presenter.OnViewLoaded();
        }

        #endregion
    }
}