using System;

namespace Aria.SDK.AriaServices.AriaWebServices
{
    public class AriaBillingBase : IDisposable
    {
        #region attributes
        public string URL;
        #endregion attributes

        #region Constructor
        /*Creates a new AriaBillingComplete with URL parm*/
        public AriaBillingBase(String URL)
        {
            if (URL == null)
            {
                return;
            }
            setURL(URL);
        }
        #endregion

        #region Disposable
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Disposable

        #region gets
        protected static string getMethod()
        {
            return "POST";
        }

        protected static string getContentType()
        {
            return "application/Json";
        }

        public string getURL()
        {
            return URL;
        }
        #endregion gets

        #region sets
        public void setURL(string url)
        {
            URL = url;
        }
        #endregion sets

        #region General methods
        protected string buildUrl(string restCallMethod)
        {
            return getURL() + "?output_format=json&rest_call=" + restCallMethod;
        }
        #endregion General methods
    }
}