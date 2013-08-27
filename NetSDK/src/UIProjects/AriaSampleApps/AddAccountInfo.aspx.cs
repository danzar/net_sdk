using System;
using System.Web.UI;
using Aria;
using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;
//using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;

public partial class AddAccountInfo : Page
{
  protected void Page_Load(object sender,
                           EventArgs e)
  {
    string state = "";
    string country = "US";

    if (!IsPostBack)
    {
      if (SessionSupport.Errors.Count > 0)
      {
        rptErrors.DataSource = SessionSupport.Errors;
        rptErrors.DataBind();
        SessionSupport.Errors = null;
      }

      var data = SessionSupport.NewAccount;
      if ((data != null) &&
          (!string.IsNullOrEmpty(data.country)))
      {
        txtFirstName.Value = data.first_name;
        txtLastName.Value = data.last_name;
        txtUserId.Value = data.userid;
        txtPassword.Value = data.password;
        txtPasswordConfirmation.Value = data.password;

        ddlSecrectQuestion.Value = data.secret_question;

        txtSecretAnswer.Value = data.secret_question_answer;
        txtStreet1.Value = data.address1;
        txtStreet2.Value = data.address2;
        txtCity.Value = data.city;
        txtZipCode.Value = data.postal_cd;
        txtPhone.Value = data.phone;
        txtEmail.Value = data.email;
        txtEmailConfirm.Value = data.email;

        country = data.country;

        switch (data.country)
        {
          case "US":
          case "CA":
            state = data.state_prov;
            break;

          default:
            state = data.locality;
            break;
        }
      }

      switch (country)
      {
        case "US":
        case "CA":
          rfvZipCode.Enabled = true;
          revUSCAPhone.Enabled = true;
          revIntlPhone.Enabled = false;
          break;

        default:
          rfvZipCode.Enabled = false;
          revUSCAPhone.Enabled = false;
          revIntlPhone.Enabled = true;
          break;
      }
      ddlCountry.SelectedValue = country;
      ucState.ShowStates(country,
                         state);
    }
  }

  protected void btnSubmit_onserverclick(object sender,
                                         EventArgs e)
  {
    create_acct_completeRequest data = SessionSupport.NewAccount;

    data.auth_key = ConfigFactory.GetAriaAuthorizationKey();
    data.client_no = ConfigFactory.GetAriaClientNumber();
    data.first_name = txtFirstName.Value;
    data.last_name = txtLastName.Value;
    data.userid = txtUserId.Value;
    data.password = txtPassword.Value;
    data.secret_question = ddlSecrectQuestion.Value;
    data.secret_question_answer = txtSecretAnswer.Value;
    data.address1 = txtStreet1.Value;
    data.address2 = txtStreet2.Value;
    data.city = txtCity.Value;
    data.country = ddlCountry.SelectedValue;
    data.phone = txtPhone.Value;
    data.email = txtEmail.Value;
    data.postal_cd = txtZipCode.Value;

    switch (data.country)
    {
      case "US":
      case "CA":
        data.state_prov = ucState.GetCurrentState();
        data.locality = "";
        break;

      default:
        data.locality = ucState.GetCurrentState();
        data.state_prov = "";
        break;
    }

    SessionSupport.NewAccount = data;
    SessionSupport.MoveToNextStep(SessionSupport.enuRegistrationSteps.AccountInfo);
  }

  protected void ddlCountry_SelectedIndexChanged(object sender,
                                                 EventArgs e)
  {
    litState.Text = ucState.ShowStates(ddlCountry.SelectedValue,
                                       "");
    switch (ddlCountry.SelectedValue)
    {
      case "US":
      case "CA":
        rfvZipCode.Enabled = true;
        revUSCAPhone.Enabled = true;
        revIntlPhone.Enabled = false;
        break;

      default:
        rfvZipCode.Enabled = false;
        revUSCAPhone.Enabled = false;
        revIntlPhone.Enabled = true;
        break;
    }
  }
}