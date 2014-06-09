using Aria.SDK.AriaServices.AriaWebServices.AriaObjectQuery;
using System;

namespace Aria.SDK.AriaServices.AriaWebServices
{
    public class AriaBillingObjectQuery : integration_servicesPortClient,
                                       IDisposable
    {
        #region Properties

        #endregion

        #region Constructor

        /// <summary>
        /// Creates a new AriaBillingCompleteObjectQuery
        /// </summary>
        public AriaBillingObjectQuery()
        {
        }

        #endregion

        #region Disposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Free other state (managed objects).
                if (this != null)
                {
                    this.Close();
                }
            }

            // Free your own state (unmanaged objects).
            // Set large fields to null.
            if (this != null)
            {
                this.Close();
            }
        }

        #endregion

        // Use C# destructor syntax for finalization code.
        ~AriaBillingObjectQuery()
        {
            // Simply call Dispose(false).
            Dispose(false);
        }
    }
}