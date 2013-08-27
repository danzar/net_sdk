using System;
using System.Web;
using Aria;
//using Aria.SDK.AriaServices.AriaRestServices;
//using Aria.SDK.AriaServices.AriaRestServices.AriaComplete;
using Aria.SDK.AriaServices.AriaWebServices;
using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;

public partial class ForgotPassword : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {

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
  protected void btnSubmit_Click(object sender,
                                 EventArgs e)
  {
    string errorMessages = "";

    if (Page.IsValid)
    {
      using (AriaBillingComplete completeService = new AriaBillingComplete())
      {
        set_sessionRequest request = new set_sessionRequest
                        {
                            user_id = txtUserId.Value.Trim(),
                            auth_key = ConfigFactory.GetAriaAuthorizationKey(),
                            client_no = ConfigFactory.GetAriaClientNumber()
                        };

          set_sessionResponse response = completeService.set_session(request);

        if (response.error_code == 0)
        {
          validate_sessionRequest valRequest = new validate_sessionRequest
                                                   {
                                                       session_id = response.session_id,
                                                       auth_key = ConfigFactory.GetAriaAuthorizationKey(),
                                                       client_no = ConfigFactory.GetAriaClientNumber()
                                                   };

            validate_sessionResponse valResponse = completeService.validate_session(valRequest);

          if (valResponse.error_code == 0)
          {
            get_acct_details_allRequest acctRequest = new get_acct_details_allRequest
                                                          {
                                                              acct_no = valResponse.account_no,
                                                              auth_key = ConfigFactory.GetAriaAuthorizationKey(),
                                                              client_no = ConfigFactory.GetAriaClientNumber()
                                                          };

              get_acct_details_allResponse acctResponse = completeService.get_acct_details_all(acctRequest);

            if (acctResponse.error_code == 0)
            {
              //validate secret question and answer
              if (!acctResponse.secret_question.Equals(ddlSecrectQuestion.Value) ||
                  !acctResponse.secret_question_answer.Equals(txtSecretAnswer.Value, StringComparison.CurrentCultureIgnoreCase))
              {
                // secret question and answer did not match
                errorMessages += "Secret question and answer did not match our records<br/>";
              }
              else
              {
                update_acct_credentialsRequest credRequest = new update_acct_credentialsRequest
                                                                 {
                                                                     account_no = valResponse.account_no,
                                                                     auth_key = ConfigFactory.GetAriaAuthorizationKey(),
                                                                     client_no = ConfigFactory.GetAriaClientNumber(),
                                                                     password = txtPassword.Value.Trim()
                                                                 };

                  update_acct_credentialsResponse credResponse = completeService.update_acct_credentials(credRequest);

                if (credResponse.error_code != 0)
                {
                  errorMessages += "Could not update credentials<br/>";
                  errorMessages += credResponse.error_msg + "<br/>";
                }
              }
            }
            else
            {
              // could not get account details
              errorMessages += "Could not retrieve account details<br/>";
              errorMessages += acctResponse.error_msg + "<br/>";
            }
          }
          else
          {
            // could not validate session
            errorMessages += "Could not validate session<br/>";
            errorMessages += valResponse.error_msg + "<br/>";
          }
        }
        else
        {
          // could not find user id
          errorMessages += "Could not validate user id<br/>";
          errorMessages += response.error_msg + "<br/>";
        }
        
        if (string.IsNullOrEmpty(errorMessages))
        {
          // redirect to login page
          HttpContext.Current.Response.Redirect("~/Login.aspx?msg=Your password has been successfully changed");
        }
        else
        {
          divLoginError.Visible = true;
          litErrors.Text = errorMessages;
        }
      }
    }
  }  // btnSubmit_Click
}
