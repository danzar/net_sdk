using System;
using System.Web;
//using Aria.SDK.AriaServices.AriaRestServices;
//using Aria.SDK.AriaServices.AriaRestServices.AriaComplete;
using Aria.SDK.AriaServices.AriaWebServices;
using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;

namespace Aria
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["msg"] != null)
            {
                // re-use error list to display that credentials have been changed successfully
                divLoginError.Visible = true;
                litErrors.Text = HttpUtility.UrlDecode(Request.QueryString["msg"]);
            }
        }

        ///--------------------------------------------------------------------------
        /// <summary>
        /// Provides the event handler for the login button click event.
        /// </summary>
        /// 
        /// <param name="sender">Set to the sender of the event</param>
        /// <param name="e">Set to the event arguments</param>
        /// 
        /// <remarks>
        /// Raises an OnLoginClicked event
        /// </remarks>
        protected void btnLogin_Click(object sender,
                                      EventArgs e)
        {
            if (Page.IsValid)
            {
                AriaBillingComplete ssousServices = new AriaBillingComplete();
                set_session_authRequest request = new set_session_authRequest
                                                      {
                                                          user_id = txtUserId.Value.Trim(),
                                                          password = txtPassword.Value.Trim(),
                                                          auth_key = ConfigFactory.GetAriaAuthorizationKey(),
                                                          client_no = ConfigFactory.GetAriaClientNumber()
                                                      };

                set_session_authResponse response = ssousServices.set_session_auth(request);

                if (response.error_code == 0)
                {
                    SessionSupport.CurrentCredential = txtPassword.Value.Trim();
                    LoginLogout.DoLogin(response.session_id,
                                        Context,
                                        chkRememberMe.Checked);
                }
                else
                {
                    divLoginError.Visible = true;
                    litErrors.Text = response.error_msg;
                }
            }
        }  // lbtnLogin_Click
    }
}