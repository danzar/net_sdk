using System;
using System.Collections.Generic;
using System.Web;
using Aria;
using Aria.SDK.AriaServices.AriaWebServices;
//using Aria.SDK.AriaServices.AriaWebServices;

public partial class AddAccountReview : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
    if(!IsPostBack)
    {
      if(SessionSupport.CurrentStep < SessionSupport.enuRegistrationSteps.Preview)
      {
        SessionSupport.MoveToCurrentStep();
      }

      switch(SessionSupport.NewAccount.pay_method)
      {
        case 1:
          litPaymentMethod.Text = "Credit Card";
          divCreditCardInfo.Visible = true;
          break;
          
        case 2:
          litPaymentMethod.Text = "ACH";
          divACHInfo.Visible = true;
          break;
          
        case 3:
          litPaymentMethod.Text = "Paypal";
          break;
          
        case 4:
          litPaymentMethod.Text = "Net Terms 30"; 
          break;
          
        case 5:
          litPaymentMethod.Text = "Net Terms 10"; 
          break;
          
        case 7:
          litPaymentMethod.Text = "Net Terms 60";
          break;
          
      }
    }
  }

  protected void btnSave_ServerClick(object sender,
                                     EventArgs e)
  {
    using (AriaBillingComplete accountService = new AriaBillingComplete())
    {
      var errs = new List<string>();


      var response = accountService.create_acct_complete(SessionSupport.NewAccount);
      
      if ((response.error_code != 0))
      {
        if(!string.IsNullOrEmpty(response.error_msg))
        {
          errs.Add(response.error_msg);
        }
        SessionSupport.Errors = errs;

        HttpContext.Current.Response.Redirect("~/AddAccountInfo.aspx");
      }
      else
      {
        if(response.invoicing_error_code != 0)
        {
          if (!string.IsNullOrEmpty(response.invoicing_error_msg))
          {
            errs.Add(response.invoicing_error_msg);
            SessionSupport.Errors = errs;
          }
        }
        SessionSupport.MoveToNextStep(SessionSupport.enuRegistrationSteps.Preview);
      }


    }
  }

  protected void btnCancel_ServerClick(object sender,
                                       EventArgs e)
  {
    SessionSupport.NewAccount = null;
    SessionSupport.NewAccountPlan = null;
    SessionSupport.CurrentStep = SessionSupport.enuRegistrationSteps.AccountInfo;
    Response.Redirect("~/Login.aspx");
  }
}
