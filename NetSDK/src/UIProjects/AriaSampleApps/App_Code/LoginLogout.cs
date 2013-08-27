using System;
using System.Configuration;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.Configuration;
using System.Threading;

namespace Aria
{
  // This class provides login and logout functions
  public static class LoginLogout
  {
    ///--------------------------------------------------------------------------
    /// <summary>
    /// Provides the functions required to log in
    /// </summary>
    /// 
    /// <param name="session_id">Set to the session id of the user logging in</param>
    /// <param name="context">Set to the current HTTP context</param>
    /// <param name="rememberMe">Set true for persistent login.  Else, set false</param>
    /// 
    /// <remarks>
    /// </remarks>
    public static void DoLogin(string session_id,
                               HttpContext context,
                               bool rememberMe)
    {
      StringBuilder rolesList = null;
      FormsAuthenticationTicket ticket = null;
      HttpCookie cookie = null;
      string encryptedStr = "";
      string url = "";
      DateTime expirationDate;
      string userData = "";
      Configuration config = null;
      AuthenticationSection authenticationSectionData = null;

      try
      {
        // store the account number in session
        SessionSupport.CurrentSessionId = session_id;

        // build a string containing the list of roles assigned to the user
        rolesList = new StringBuilder();
        
        // create an authentication ticket for the user with an expiration
        // time of as a function of the rememberMe parameter and placing the 
        // User's roles in the userData property
        if (rememberMe)
        {
          expirationDate = DateTime.Now.AddYears(10);
        }
        else
        {
          // Set the expiration of the Authentication cookie to the number of 
          // minutes configured in the Authentication element of web.config
          config = (Configuration)(WebConfigurationManager.OpenWebConfiguration(("")));
          authenticationSectionData = config.GetSection("system.web/authentication") as AuthenticationSection;

          // set the expiration time to be slightly less than the session timeout to ensure the authentication times out first
          expirationDate = DateTime.Now.AddMinutes(authenticationSectionData.Forms.Timeout.Minutes - 1);
        }

        // Build a string containing the role data to put in the UserData property of the ticket 
        //userData = rolesList.ToString();

        ticket = new FormsAuthenticationTicket(1,
                                               session_id,
                                               DateTime.Now,
                                               expirationDate,
                                               rememberMe,
                                               userData);

        encryptedStr = FormsAuthentication.Encrypt(ticket);

        // add the encrypted authentication ticket in the cookies collection
        // and if the cookie is to be persisted, set the expiration for 
        // 10 years from now.  Otherwise do not set the expiration or the
        // cookie will be created as a persistent cookie.
        cookie = new HttpCookie(FormsAuthentication.FormsCookieName,
                                encryptedStr);
        cookie.Domain = FormsAuthentication.CookieDomain;
        
        if (rememberMe)
        {
          cookie.Expires = expirationDate;
        }

        context.Response.Cookies.Add(cookie);

        url = "~/USS.aspx";
        
        // NOTE: This must be a Response.Redirect to write the cookie to the user's
        //       browser.  Do NOT change to Server.Transfer which does not cause a
        //       round trip to the client browser.  We need this cookie written
        //       for access to all pages.
        context.Response.Redirect(url,
                                  true);
      }
      catch (ThreadAbortException)
      {
        // do nothing - This is only put in to avoid the annoying exception assistant
        // that is displayed because a ThreadAbortException is thrown on a redirect
      }
      catch (Exception exc)
      {
        throw new Exception("There was an error logging in, please try again",
                            exc);
      }
    }  // doLogin

    ///--------------------------------------------------------------------------
    /// <summary>
    /// Provides the functions required to logout
    /// </summary>
    ///  
    /// <remarks>
    /// </remarks>
    public static void DoLogout()
    {
      HttpContext context = null;
      string url = "";

      try
      {
        context = HttpContext.Current;

        // destroy the user authentication cookie
        FormsAuthentication.SignOut();

        // clear session variables with user information
        context.Session.Clear();
        context.Session.Abandon();

        // redirect to the login page
        // NOTE: This must be a Response.Redirect to delete the cookie from the user's
        //       browser.  Do NOT change to Server.Transfer which does not cause a
        //       round trip to the client browser.
        url = "~/Login.aspx";
        
        context.Response.Redirect(url,
                                  true);
      }

      catch (ThreadAbortException)
      {
        // do nothing - This is only put in to avoid the annoying exception assistant
        // that is displayed because a ThreadAbortException is thrown on a redirect
      }

      catch (Exception exc)
      {
        throw new Exception("There was an error logging out",
                             exc);
      }
    }  //doLogout

  }  // LoginLogout
}