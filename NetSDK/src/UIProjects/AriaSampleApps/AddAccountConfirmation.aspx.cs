using System;
using System.Web.UI;
using Aria;
using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;

public partial class AddAccountConfirmation : Page
{
  private const string VS_ACCOUNT = "AddAccountconfirmation-Account";
  private const string VS_ACCOUNT_PLAN = "AddAccountconfirmation-AccountPlan";

  protected create_acct_completeRequest NewAccount
  {
    get
    {
      return (create_acct_completeRequest)ViewState[VS_ACCOUNT];
    }
  }
  protected all_client_plans_ReturnElement NewAccountPlan
  {
    get
    {
      return (all_client_plans_ReturnElement)ViewState[VS_ACCOUNT_PLAN];
    }
  }

  protected void Page_Load(object sender,
                           EventArgs e)
  {
    if (!IsPostBack)
    {
      ViewState[VS_ACCOUNT] = SessionSupport.NewAccount;
      ViewState[VS_ACCOUNT_PLAN] = SessionSupport.NewAccountPlan;

      if (SessionSupport.Errors.Count > 0)
      {
        rptErrors.DataSource = SessionSupport.Errors;
        rptErrors.DataBind();
        SessionSupport.Errors = null;
      }
    }
    SessionSupport.NewAccount = null;
    SessionSupport.NewAccountPlan = null;
    SessionSupport.CurrentStep = SessionSupport.enuRegistrationSteps.AccountInfo;
  }
}