using System;
//using Aria.SDK.AriaServices.AriaRestServices;
//using Aria.SDK.AriaServices.AriaRestServices.AriaComplete;
using Aria.SDK.AriaServices.AriaWebServices;
using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;

namespace Aria
{
  public partial class Logout : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      AriaBillingComplete ssousServices = new AriaBillingComplete();
      kill_sessionRequest request = new kill_sessionRequest
                                        {
                                            session_id = SessionSupport.CurrentSessionId,
                                            auth_key = ConfigFactory.GetAriaAuthorizationKey(),
                                            client_no = ConfigFactory.GetAriaClientNumber()
                                        };

        ssousServices.kill_session(request);

      LoginLogout.DoLogout();

    }
  }
}