using System;
using Aria;

public partial class LoginNavigationControl : System.Web.UI.UserControl
{
  protected void Page_Load(object sender, EventArgs e)
  {
    const string COMPLETED_IMAGE_PATH = "App_Themes/images/accept.png";
    if(!Page.IsPostBack)
    {
      if (SessionSupport.CurrentStep > SessionSupport.enuRegistrationSteps.AccountInfo)
      {
        spEditAccount.Visible = true;
        imgAccountInformation.Src = COMPLETED_IMAGE_PATH;
      }
      if (SessionSupport.CurrentStep > SessionSupport.enuRegistrationSteps.PlanInfo)
      {
        spPlanInformation.Visible = true;
        imgPlanInformation.Src = COMPLETED_IMAGE_PATH;
      }
      if (SessionSupport.CurrentStep > SessionSupport.enuRegistrationSteps.PaymentInfo)
      {
        spPaymentInformation.Visible = true;
        imgPaymentInformation.Src = COMPLETED_IMAGE_PATH;
      }
    }
  }
}
