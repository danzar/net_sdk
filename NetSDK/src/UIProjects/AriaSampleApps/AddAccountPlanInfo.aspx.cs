using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aria;
using Aria.SDK.AriaServices.AriaWebServices;
using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;
//using Aria.SDK.AriaServices.AriaWebServices;
//using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;

public partial class AddAccountPlanInfo : Page
{
  protected void Page_Load(object sender,
                             EventArgs e)
  {
    if (!IsPostBack)
    {
      if (SessionSupport.CurrentStep < SessionSupport.enuRegistrationSteps.PlanInfo)
      {
        SessionSupport.MoveToCurrentStep();
      }

      using (AriaBillingComplete systemServices = new AriaBillingComplete())
      {
        get_client_plans_allRequest plansRequest = new get_client_plans_allRequest()
                                              {
                                                auth_key = ConfigFactory.GetAriaAuthorizationKey(),
                                                client_no = ConfigFactory.GetAriaClientNumber()
                                              };

        get_client_plans_allResponse plansResponse = systemServices.get_client_plans_all(plansRequest);

        ddlPlans.DataSource = plansResponse.all_client_plans;
        ddlPlans.DataBind();

        ddlPlans.Items.Insert(0,
                              new ListItem("Select Plan",
                                           ""));

        var li = ddlPlans.Items.FindByValue(SessionSupport.NewAccount.master_plan_no.ToString());

        if (li != null)
        {
          li.Selected = true;
        }
      }
    }
  }

  //get_client_plans_all
  protected void btnSubmit_ServerClick(object sender,
                                       EventArgs e)
  {
    long planNumber;
    if (long.TryParse(ddlPlans.Value,
                      out planNumber))
    {
      create_acct_completeRequest data = SessionSupport.NewAccount;

      data.master_plan_no = planNumber;

      SessionSupport.NewAccount = data;

      get_client_plans_allRequest getClientPlan = new get_client_plans_allRequest
                                             {
                                               auth_key = ConfigFactory.GetAriaAuthorizationKey(),
                                               client_no = ConfigFactory.GetAriaClientNumber(),
                                               plan_no = planNumber
                                             };

      using (var ariaBillingService = new AriaBillingComplete())
      {

        var response = ariaBillingService.get_client_plans_all(getClientPlan);
        if ((response.error_code == 0) &&
            (response.all_client_plans.Length > 0))
        {
          SessionSupport.NewAccountPlan = response.all_client_plans[0];
        }

        SessionSupport.MoveToNextStep(SessionSupport.enuRegistrationSteps.PlanInfo);
      }
    }
  }
}