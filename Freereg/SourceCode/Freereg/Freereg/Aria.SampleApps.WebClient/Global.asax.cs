using Aria.SampleApps.Common.Utils;

namespace ARIA
{
    using System;
    using System.Reflection;
    using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
    using Microsoft.Practices.ServiceLocation;
    using Resources;

    public class Global : System.Web.HttpApplication
    {
        /// <summary>
        /// Check if the Application is Initialized.
        /// </summary>
        private static bool initialized;

        /// <summary>
        /// Handles the Start event of the Application control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <Author>Esteban Diaz</Author>
        protected void Application_Start(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Handles the Start event of the Session control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <Author>Esteban Diaz</Author>
        protected void Session_Start(object sender, EventArgs e)
        {
            initialized = false;
        }

        /// <summary>
        /// Handles the BeginRequest event of the Application control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <Author>Esteban Diaz</Author>
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            if (!initialized)
            {
                initialized = true;
                //Bootstrapper.Run();
            }

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-CO");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("es-CO");
        }

        /// <summary>
        /// Handles the AuthenticateRequest event of the Application control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <Author>Esteban Diaz</Author>
        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Error event of the Application control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <Author>Esteban Diaz</Author>
        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exp = Server.GetLastError();
            ErrorLog.SaveExceptionLog(exp);
        }

        /// <summary>
        /// Handles the End event of the Session control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <Author>Esteban Diaz</Author>
        protected void Session_End(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the End event of the Application control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <Author>Esteban Diaz</Author>
        protected void Application_End(object sender, EventArgs e)
        {
        }
    }
}
