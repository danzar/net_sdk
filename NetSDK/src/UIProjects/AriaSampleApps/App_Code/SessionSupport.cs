using System.Collections.Generic;
using System.Web;
using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;

namespace Aria
{
  ///------------------------------------------------------------------
  /// <summary>
  /// A static class intended to contain all references to Session in 
  /// one location.
  /// </summary>
  ///------------------------------------------------------------------
  public static class SessionSupport
  {
    private const string SES_CURRENT_SESSION_ID = "SessionSupport-CurrentSessionId";
    private const string SES_CURRENT_ACCOUNT_NUMBER = "SessionSupport-CurrentAccountNumber";
    private const string SES_CURRENT_CREDENTIAL = "SessionSupport-CurrentCredential";
    private const string SES_NEW_ACCOUNT = "SessionSupport-NewAccount";
    private const string SES_NEW_ACCOUNT_PLAN = "SessionSupport-NewAccountPlan";
    private const string SES_NEW_ACCOUNT_CURRENT_STEP = "SessionSupport-NewAccountCurrentStep";
    private const string SES_ERRORS = "SessionSupport-Errors";

    public enum enuRegistrationSteps
    {
      AccountInfo = 1,
      PlanInfo = 2,
      PaymentInfo = 3,
      Preview = 4,
      Confirmation = 5
    }

    ///------------------------------------------------------------------
    /// <summary>
    /// Gets/Sets the current session id.
    /// </summary>
    ///------------------------------------------------------------------
    public static string CurrentSessionId
    {
      get
      {
        string session_id = "";

        if (HttpContext.Current.Session[SES_CURRENT_SESSION_ID] != null)
        {
          session_id = (string)HttpContext.Current.Session[SES_CURRENT_SESSION_ID];
        }

        if (string.IsNullOrEmpty(session_id) &&
            HttpContext.Current.Request.IsAuthenticated)
        {
          //if the user account data is null but the account is authenticated then the session timed out
          //and we must logout
          LoginLogout.DoLogout();
        }

        return session_id;
      }
      set
      {
        HttpContext.Current.Session[SES_CURRENT_SESSION_ID] = value;
      }
    }

    ///------------------------------------------------------------------
    /// <summary>
    /// Gets/Sets the current credential.
    /// </summary>
    ///------------------------------------------------------------------
    public static string CurrentCredential
    {
      get
      {
        string credential = "";

        if (HttpContext.Current.Session[SES_CURRENT_CREDENTIAL] != null)
        {
          credential = (string)HttpContext.Current.Session[SES_CURRENT_CREDENTIAL];
        }

        if (string.IsNullOrEmpty(credential) &&
            HttpContext.Current.Request.IsAuthenticated)
        {
          //if the user account data is null but the account is authenticated then the session timed out
          //and we must logout
          LoginLogout.DoLogout();
        }

        return credential;
      }
      set
      {
        HttpContext.Current.Session[SES_CURRENT_CREDENTIAL] = value;
      }
    }

    ///------------------------------------------------------------------
    /// <summary>
    /// Gets/Sets the current account number.
    /// </summary>
    ///------------------------------------------------------------------
    public static long CurrentAccountNumber
    {
      get
      {
        long account_no = 0;

        if (HttpContext.Current.Session[SES_CURRENT_ACCOUNT_NUMBER] != null)
        {
          account_no = (long)HttpContext.Current.Session[SES_CURRENT_ACCOUNT_NUMBER];
        }

        if (account_no == 0 &&
            HttpContext.Current.Request.IsAuthenticated)
        {
          //if the user account data is null but the account is authenticated then the session timed out
          //and we must logout
          LoginLogout.DoLogout();
        }

        return account_no;
      }
      set
      {
        HttpContext.Current.Session[SES_CURRENT_ACCOUNT_NUMBER] = value;
      }
    }

    public static create_acct_completeRequest NewAccount
    {
      get
      {
        create_acct_completeRequest data;
        if (HttpContext.Current.Session[SES_NEW_ACCOUNT] != null)
        {
          data = (create_acct_completeRequest)HttpContext.Current.Session[SES_NEW_ACCOUNT];
        }
        else
        {
          data = new create_acct_completeRequest();
        }

        return data;
      }
      set
      {
        HttpContext.Current.Session[SES_NEW_ACCOUNT] = value;
      }
    }

    public static all_client_plans_ReturnElement NewAccountPlan
    {
      get
      {
        all_client_plans_ReturnElement data;
        if (HttpContext.Current.Session[SES_NEW_ACCOUNT_PLAN] != null)
        {
          data = (all_client_plans_ReturnElement)HttpContext.Current.Session[SES_NEW_ACCOUNT_PLAN];
        }
        else
        {
          data = new all_client_plans_ReturnElement();
        }

        return data;
      }
      set
      {
        HttpContext.Current.Session[SES_NEW_ACCOUNT_PLAN] = value;
      }
    }


    public static enuRegistrationSteps CurrentStep
    {
      get
      {
        enuRegistrationSteps step = enuRegistrationSteps.AccountInfo;
        if (HttpContext.Current.Session[SES_NEW_ACCOUNT_CURRENT_STEP] != null)
        {
          step = (enuRegistrationSteps)HttpContext.Current.Session[SES_NEW_ACCOUNT_CURRENT_STEP];
        }

        return step;
      }
      set
      {
        HttpContext.Current.Session[SES_NEW_ACCOUNT_CURRENT_STEP] = value;
      }
    }

    public static List<string> Errors
    {
      get
      {
        var errs = new List<string>();
        
        if (HttpContext.Current.Session[SES_ERRORS] != null)
        {
          errs = (List<string>)HttpContext.Current.Session[SES_ERRORS];
        }

        return errs;
      }
      set
      {
        HttpContext.Current.Session[SES_ERRORS] = value;
        
      }
    }

    public static void MoveToNextStep(enuRegistrationSteps leavingStep)
    {
      if (CurrentStep == leavingStep)
      {
        CurrentStep = CurrentStep + 1;
      }

      MoveToCurrentStep();
    }

    public static void MoveToCurrentStep()
    {

      switch (CurrentStep)
      {
        case enuRegistrationSteps.AccountInfo:
          HttpContext.Current.Response.Redirect("~/AddAccountInfo.aspx");
          break;

        case enuRegistrationSteps.PlanInfo:
          HttpContext.Current.Response.Redirect("~/AddAccountPlanInfo.aspx");
          break;

        case enuRegistrationSteps.PaymentInfo:
          HttpContext.Current.Response.Redirect("~/AddAccountPaymentInformation.aspx");
          break;

        case enuRegistrationSteps.Preview:
          HttpContext.Current.Response.Redirect("~/AddAccountReview.aspx");
          break;

        case enuRegistrationSteps.Confirmation:
          HttpContext.Current.Response.Redirect("~/AddAccountConfirmation.aspx");
          break;

      }
    }
  }
}