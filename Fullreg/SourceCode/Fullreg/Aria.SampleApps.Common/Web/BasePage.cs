// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BasePage.cs" company="INS">
//    Copyright (c) Sivicap 2010. All rights reserved. 
// </copyright>
// <author>Esteban Diaz</author>
// <summary>
//   Base Page.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Web.UI.WebControls;
using Aria.SampleApps.Common.Enum;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Globalization;
using System.Threading;

namespace Aria.SampleApps.Common.Web
{
    /// <summary>
    /// Base Class for all the mvp pages.
    /// </summary>
    public class BasePage : System.Web.UI.Page
    {
        public ARIASDKPages idPreviousPage
        {
            get
            {
                return Session["_currentPageId"] != null ? (ARIASDKPages)Session["_currentPageId"] : ARIASDKPages.Next;
            }
            set
            {
                Session["_currentPageId"] = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasePage"/> class.
        /// </summary>
        /// <author>Esteban Diaz</author>
        public BasePage()
        {
            PreInit += this.BasePagePreInit;
        }

        /// <summary>
        /// Handles Page Load Event
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Esteban Diaz</author>
        protected void BasePagePreInit(object sender, EventArgs e)
        {            
        }

        /// <summary>
        /// Overriding the InitializeCulture method to set the user selected
        /// option in the current thread. This method is called much
        /// earlier in the Page lifecycle and we don't have access to any controls
        /// in this stage, so have to use Form collection.
        /// </summary>
        /// <author>Esteban Diaz</author>
        protected override void InitializeCulture()
        {
            base.InitializeCulture();

            /* Get the culture from the session if the control is tranferred to a
               new page in the same application.*/
            CultureInfo currentCultureInfo = Session["CurrentCultureInfo"] as CultureInfo;
            if (currentCultureInfo == null)
            {
                // Set the current culture
                currentCultureInfo = new CultureInfo("es-CO");
                Session["CurrentCultureInfo"] = currentCultureInfo;
            }

            Thread.CurrentThread.CurrentUICulture = currentCultureInfo;
            Thread.CurrentThread.CurrentCulture = currentCultureInfo;
        }

        protected override void OnLoad(EventArgs e)
        {
            if(!IsPostBack)
            {
               
            }

            base.OnLoad(e);
        }

        protected void MoveForward()
        {
            string pageName = "";
            if (idPreviousPage != ARIASDKPages.Next)
            {
                pageName = stringValueOf(idPreviousPage);
                idPreviousPage = ARIASDKPages.Next;
                Response.Redirect(pageName);
            }
            else
            {
                int nextPageId = 0;
                string currentPage = Request.Path.ToLower();
                foreach (ARIASDKPages val in ARIASDKPages.GetValues(typeof(ARIASDKPages)))
                {
                    pageName = stringValueOf(val).ToLower();
                    if (!string.IsNullOrEmpty(pageName) && currentPage.Contains(pageName))
                    {
                        nextPageId = (int)val;

                        if (nextPageId <= 7)
                            nextPageId++;
                        else
                            nextPageId = 1;

                        break;
                    }
                }

                ARIASDKPages nextPage = (ARIASDKPages)nextPageId;
                currentPage = stringValueOf(nextPage);
                Response.Redirect(currentPage);
            }
        }

        protected void MoveBackward(ARIASDKPages redirectPage)
        {
            string pageName = "", currentPage = Request.Path.ToLower();
            int currentPageId = 0;
            foreach (ARIASDKPages val in ARIASDKPages.GetValues(typeof(ARIASDKPages)))
            {
                pageName = stringValueOf(val).ToLower();
                if (!string.IsNullOrEmpty(pageName) && currentPage.Contains(pageName))
                {
                    currentPageId = (int)val;
                    break;
                }
            }

            idPreviousPage = (ARIASDKPages)currentPageId;
            pageName = stringValueOf(redirectPage);
            Response.Redirect(pageName);
        }

        private string stringValueOf(ARIASDKPages val)
        {
            FieldInfo fi = val.GetType().GetField(val.ToString());
            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return val.ToString();
            }
        }                   
    }
}
