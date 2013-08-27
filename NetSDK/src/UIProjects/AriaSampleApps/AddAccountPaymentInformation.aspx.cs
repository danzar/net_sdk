using System;
using Aria;
using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;
//using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;

public partial class AddAccountPaymentInformation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (SessionSupport.CurrentStep < SessionSupport.enuRegistrationSteps.PaymentInfo)
            {
                SessionSupport.MoveToCurrentStep();
            }

            var data = SessionSupport.NewAccount;
            txtBillFirstName.Value = data.bill_first_name;
            txtBillLastName.Value = data.bill_last_name;
            txtCCNumber.Value = data.cc_number;
            txtCVV.Value = data.cvv;
            txtRoutingNumber.Value = data.bank_routing_no;
            txtAccountNumber.Value = data.bank_acct_no;
            SetAddressFields(data);

            var li = ddlExpMonth.Items.FindByValue(data.cc_expire_mm.ToString());
            if (li != null)
            {
                li.Selected = true;
            }

            for (int i = DateTime.Now.Year; i < DateTime.Now.Year + 15; i++)
            {
                ddlExpirationYear.Items.Add(i.ToString());
            }
            li = ddlExpirationYear.Items.FindByValue(data.cc_expire_yyyy.ToString());
            if (li != null)
            {
                li.Selected = true;
            }

            li = ddlPaymentType.Items.FindByValue(SessionSupport.NewAccount.pay_method.ToString());
            if (li != null)
            {
                li.Selected = true;
            }

            string paymethodJS;

            switch (data.pay_method)
            {
                case 1:
                    paymethodJS = "show21('Ccard'); hide21('ACH');setACHValidators(false);setCCValidators(true);";
                    break;

                case 2:
                    paymethodJS = "hide21('Ccard'); show21('ACH');setACHValidators(true);setCCValidators(false);";
                    break;

                default:
                    paymethodJS = "hide21('Ccard'); hide21('ACH');setACHValidators(false);setCCValidators(false);";

                    break;

            }
            ClientScript.RegisterStartupScript(GetType(),
                                               "setInitialPaymentMethod",
                                               paymethodJS,
                                               true);
        }
    }

    private void SetAddressFields(create_acct_completeRequest data)
    {
        string state;
        if (string.IsNullOrEmpty(data.bill_country))
        {
            data.bill_country = data.country;
        }
        txtBillAddress1.Value = data.bill_address1;
        txtBillAddress2.Value = data.bill_address2;
        txtBillCity.Value = data.bill_city;
        ddlCountry.SelectedValue = data.bill_country;
        txtBillZip.Value = data.bill_postal_cd;

        revUSZip.Enabled = false;
        revCAZip.Enabled = false;
        revOtherZip.Enabled = false;
        switch (data.bill_country)
        {
            case "US":
                state = data.bill_state_prov;
                revUSZip.Enabled = true;
                break;

            case "CA":
                state = data.bill_state_prov;
                revCAZip.Enabled = true;
                break;

            default:
                state = data.bill_locality;
                revOtherZip.Enabled = true;
                break;
        }

        ddlCountry.SelectedValue = data.bill_country;
        litState.Text = ucState.ShowStates(data.bill_country,
                            state);
    }

    protected void chkBillingSameAsShipping_CheckedChanged(object sender,
                                                           EventArgs e)
    {
        var data = SessionSupport.NewAccount;
        data.bill_address1 = data.address1;
        data.bill_address2 = data.address2;
        data.bill_city = data.city;
        data.bill_country = data.country;
        data.bill_first_name = data.first_name;
        data.bill_last_name = data.last_name;
        data.bill_postal_cd = data.postal_cd;
        data.bill_state_prov = data.state_prov;
        data.bill_locality = data.locality;

        SetAddressFields(data);
        ClientScript.RegisterStartupScript(GetType(),
                                           "setInitialPaymentMethod",
                                           "show21('Ccard'); hide21('ACH');setACHValidators(false);setCCValidators(true);",
                                           true);
    }

    protected void btnSubmit_ServerClick(object sender,
                                         EventArgs e)
    {
        var data = SessionSupport.NewAccount;
        int payMethod;

        if (int.TryParse(ddlPaymentType.Value, out payMethod))
        {
            data.pay_method = payMethod;
            switch (payMethod)
            {
                case 1:
                    data.cc_expire_mm = Convert.ToInt32(ddlExpMonth.Value);
                    data.cc_expire_yyyy = Convert.ToInt32(ddlExpirationYear.Value);
                    data.bill_address1 = txtBillAddress1.Value;
                    data.bill_address2 = txtBillAddress2.Value;
                    data.bill_city = txtBillCity.Value;
                    data.bill_country = ddlCountry.SelectedValue;
                    data.bill_first_name = txtBillFirstName.Value;
                    data.bill_last_name = txtBillLastName.Value;
                    data.bill_postal_cd = txtBillZip.Value;
                    data.cc_number = txtCCNumber.Value;
                    data.cvv = txtCVV.Value;

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


                    break;

                case 2:
                    data.bank_routing_no = txtRoutingNumber.Value;
                    data.bank_acct_no = txtAccountNumber.Value;
                    break;

                default:

                    break;

            }
            SessionSupport.NewAccount = data;
            SessionSupport.MoveToNextStep(SessionSupport.enuRegistrationSteps.PaymentInfo);
        }
    }

    protected void ddlCountry_SelectedIndexChanged(object sender,
                                                   EventArgs e)
    {
        litState.Text = ucState.ShowStates(ddlCountry.SelectedValue,
                                           "");

        revUSZip.Enabled = false;
        revCAZip.Enabled = false;
        revOtherZip.Enabled = false;
        switch (ddlCountry.SelectedValue)
        {
            case "US":
                revUSZip.Enabled = true;
                break;

            case "CA":
                revCAZip.Enabled = true;
                break;

            default:
                revOtherZip.Enabled = true;
                break;
        }
        ClientScript.RegisterStartupScript(GetType(),
                                           "setInitialPaymentMethod",
                                           "show21('Ccard'); hide21('ACH');setACHValidators(false);setCCValidators(true);",
                                           true);
    }
}
