// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseUserControl.cs" company="INS">
//    Copyright (c) Sivicap 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez usuga</author>
// <summary>
//   Base Class for all the mvp user controls.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using Microsoft.Practices.CompositeWeb;

namespace Aria.SampleApps.Common.Web
{
    /// <summary>
    /// User Control Class for all the mvp pages.
    /// </summary>
    public class MvpBaseUserControl<TPresenter, TView> : BaseUserControl
        where TPresenter : Presenter<TView>
        where TView : class
    {
        #region Mvp configuration

        protected TPresenter Presenter;

        /// <summary>
        /// Gets or sets the presenter.
        /// </summary>
        /// <value>The presenter.</value>
        /// <author>Alejandro Ramirez H</author>
        public TPresenter presenter
        {
            get
            {
                return Presenter;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }

                Presenter = value;
                Presenter.View = this as TView;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasePage"/> class.
        /// </summary>
        /// <author>Víctor Manuel Velásquez C.</author>
        public MvpBaseUserControl()
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
            if (!IsPostBack)
            {
                presenter.OnViewInitialized();
            }

            presenter.OnViewLoaded();
        }

        #endregion
    }
}
