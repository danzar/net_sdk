using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;
using Aria.SDK.AriaServices.AriaWebServices;
//using Aria.SDK.AriaServices.AriaWebServices;
//using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;

namespace Aria
{
    public partial class USS : Page
    {
        private string PayMethodScript { get; set; }

        protected void Page_Load(object sender,
                                 EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                divChangesMessage.Visible = false;
                using (AriaBillingComplete ssousServices = new AriaBillingComplete())
                {
                    //use the using block so that dispose is called. In dispose the connection in closed.
                    validate_sessionRequest request = new validate_sessionRequest
                                                          {
                                                              session_id = SessionSupport.CurrentSessionId,
                                                              auth_key = ConfigFactory.GetAriaAuthorizationKey(),
                                                              client_no = ConfigFactory.GetAriaClientNumber()
                                                          };

                    validate_sessionResponse response = ssousServices.validate_session(request);

                    if (response.error_code == 0)
                    {
                        SessionSupport.CurrentAccountNumber = response.account_no;
                        Page.ClientScript.RegisterStartupScript(typeof(Page),
                                                                Guid.NewGuid().ToString(),
                                                                "javascript:toggleTabs('tab1');",
                                                                true);
                        InitializeForm(response.account_no);
                    }
                    else
                    {
                        Response.Redirect("~/Login.aspx");
                    }
                }
            }
        }

        ///--------------------------------------------------------------------------
        /// <summary>
        /// Provides the event handler for the submit acct button click event.
        /// </summary>
        /// 
        /// <param name="sender">Set to the sender of the event</param>
        /// <param name="e">Set to the event arguments</param>
        /// 
        /// <remarks>
        /// </remarks>
        protected void btnSubmitAcct_Click(object sender,
                                           EventArgs e)
        {
            string script = "javascript:toggleTabs('tab1');";

            if (Page.IsValid)
            {
                using (AriaBillingComplete completeService = new AriaBillingComplete())
                {
                    //use the using block so that dispose is called. In dispose the connection in closed.
                    update_acct_contactRequest request = new update_acct_contactRequest();
                    update_acct_contactResponse response = null;
                    request.auth_key = ConfigFactory.GetAriaAuthorizationKey();
                    request.client_no = ConfigFactory.GetAriaClientNumber();
                    request.account_no = SessionSupport.CurrentAccountNumber;
                    request.address1 = txtAddress1.Value.Trim();
                    request.address2 = txtAddress2.Value.Trim();
                    request.alt_email = txtEmail.Value.Trim();
                    request.city = txtCity.Value.Trim();
                    request.country = ddlCountry.SelectedValue;
                    request.first_name = txtFirstName.Value.Trim();
                    request.intl_phone = txtPhone.Value.Trim();
                    request.last_name = txtLastName.Value.Trim();
                    request.postal_code = txtZipCode.Value.Trim();
                    switch (request.country)
                    {
                        case "US":
                            request.state_prov = ucState.GetCurrentState();
                            request.locality = "";
                            break;
                        case "CA":
                            request.state_prov = ucState.GetCurrentState();
                            request.locality = "";
                            break;
                        default:
                            request.locality = ucState.GetCurrentState();
                            request.state_prov = "";
                            break;
                    }

                    response = completeService.update_acct_contact(request);

                    litChangesMessage.Text = " Your changes have been saved. ";

                    divChangesMessage.Visible = true;
                    if (response.error_code != 0)
                    {
                        litChangesMessage.Text = response.error_msg;
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(txtCurrentPassword.Value.Trim()))
                        {
                            Page.Validate("EDIT_PASSWORD");
                            if (Page.IsValid)
                            {
                                update_acct_credentialsRequest credRequest = new update_acct_credentialsRequest();
                                update_acct_credentialsResponse credResponse = null;

                                credRequest.account_no = SessionSupport.CurrentAccountNumber;
                                credRequest.auth_key = ConfigFactory.GetAriaAuthorizationKey();
                                credRequest.client_no = ConfigFactory.GetAriaClientNumber();
                                credRequest.password = txtPassword.Value.Trim();

                                credResponse = completeService.update_acct_credentials(credRequest);

                                if (credResponse.error_code != 0)
                                {
                                    litChangesMessage.Text = credResponse.error_msg;
                                }
                                else
                                {
                                    // empty password fields and update session with new password
                                    SessionSupport.CurrentCredential = txtPassword.Value;
                                    txtPassword.Value = "";
                                    txtCurrentPassword.Value = "";
                                    txtRetypePassword.Value = "";
                                }
                            }
                            else
                            {
                                divChangesMessage.Visible = false;
                                litChangesMessage.Text = "";
                                script +=
                                  "openEditor('company'); show21('info_section_edit_link1_company');hide21('pass0'); show21('pass1'); show21('pass2'); show21('pass3');  show21('pass4');";
                            }
                        }
                    }

                    get_acct_details_allRequest acctRequest = new get_acct_details_allRequest();
                    get_acct_details_allResponse acctResponse = null;

                    acctRequest.acct_no = SessionSupport.CurrentAccountNumber;
                    acctRequest.auth_key = ConfigFactory.GetAriaAuthorizationKey();
                    acctRequest.client_no = ConfigFactory.GetAriaClientNumber();

                    acctResponse = completeService.get_acct_details_all(acctRequest);

                    BindAccountInfo(acctResponse);
                    Page.ClientScript.RegisterStartupScript(typeof(Page),
                                                            Guid.NewGuid().ToString(),
                                                            script + GetBillingScript(),
                                                            true);
                }
            }
        }

        // lbtnSubmitAcct_Click

        ///--------------------------------------------------------------------------
        /// <summary>
        /// Provides the event handler for the submit plan button click event.
        /// </summary>
        /// 
        /// <param name="sender">Set to the sender of the event</param>
        /// <param name="e">Set to the event arguments</param>
        /// 
        /// <remarks>
        /// </remarks>
        protected void btnSubmitPlan_Click(object sender,
                                           EventArgs e)
        {
            if (Page.IsValid)
            {
                using (AriaBillingComplete completeService = new AriaBillingComplete())
                {
                    //use the using block so that dispose is called. In dispose the connection in closed.
                    update_master_planRequest request = new update_master_planRequest();
                    update_master_planResponse response = null;

                    request.auth_key = ConfigFactory.GetAriaAuthorizationKey();
                    request.client_no = ConfigFactory.GetAriaClientNumber();
                    request.acct_no = SessionSupport.CurrentAccountNumber;
                    request.master_plan_no = long.Parse(ddlAllPlans.SelectedValue);
                    //assignment directive of 4 indicates that the change is to take place immediately
                    request.assignment_directive = 4;
                    response = completeService.update_master_plan(request);

                    divChangesMessage.Visible = true;
                    if (response.error_code != 0)
                    {
                        litChangesMessage.Text = response.error_msg;
                    }
                    else
                    {
                        litPlanName.Text = ddlAllPlans.SelectedItem.Text;
                        litChangesMessage.Text = " Your changes have been saved. ";
                    }

                }
                Page.ClientScript.RegisterStartupScript(typeof(Page),
                                                        Guid.NewGuid().ToString(),
                                                        "javascript:toggleTabs('tab2');" + GetBillingScript(),
                                                        true);
            }
        }

        // lbtnSubmitPlan_Click

        ///--------------------------------------------------------------------------
        /// <summary>
        /// Provides the event handler for the submit billing button click event.
        /// </summary>
        /// 
        /// <param name="sender">Set to the sender of the event</param>
        /// <param name="e">Set to the event arguments</param>
        /// 
        /// <remarks>
        /// </remarks>
        protected void btnSubmitBilling_Click(object sender,
                                              EventArgs e)
        {
            string script = "javascript:toggleTabs('tab3'); openEditor('billing'); show21('info_section_edit_link1_billing');";
            bool updated = false;
            try
            {

                using (AriaBillingComplete acctServicesCC = new AriaBillingComplete())
                {
                    //use the using block so that dispose is called. In dispose the connection in closed.
                    switch (ddlPayTypes.SelectedValue)
                    {
                        case "1":
                            script += "show21('Ccard'); show21('cc_details'); hide21('ACH');";
                            Page.Validate("EDIT_PAYMENT_CC");

                            if (Page.IsValid)
                            {
                                set_pay_method_ccRequest ccRequest = new set_pay_method_ccRequest();

                                set_pay_method_ccResponse ccResponse = null;
                                ccRequest.account_no = SessionSupport.CurrentAccountNumber;
                                ccRequest.auth_key = ConfigFactory.GetAriaAuthorizationKey();
                                ccRequest.client_no = ConfigFactory.GetAriaClientNumber();
                                ccRequest.cc_expire_mm = long.Parse(ddlMonth.SelectedValue);
                                ccRequest.cc_expire_yyyy = long.Parse(ddlYear.SelectedValue);
                                ccRequest.cc_number = txtCCNumber.Value;

                                ccResponse = acctServicesCC.set_pay_method_cc(ccRequest);
                                divChangesMessage.Visible = true;
                                if (ccResponse.error_code != 0)
                                {
                                    litChangesMessage.Text = ccResponse.error_msg;
                                }
                                else
                                {
                                    updated = true;
                                    litChangesMessage.Text = " Your changes have been saved. ";
                                }
                            }
                            break;
                        case "2":
                            script += "show21('ACH'); hide21('Ccard'); hide21('cc_details');";
                            Page.Validate("EDIT_PAYMENT_ACH");

                            if (Page.IsValid)
                            {
                                set_pay_method_bank_draftRequest achRequest = new set_pay_method_bank_draftRequest();

                                set_pay_method_bank_draftResponse achResponse = null;
                                achRequest.account_no = SessionSupport.CurrentAccountNumber;
                                achRequest.auth_key = ConfigFactory.GetAriaAuthorizationKey();
                                achRequest.client_no = ConfigFactory.GetAriaClientNumber();
                                achRequest.bank_acct_num = txtBankAccountNumber.Value;
                                achRequest.bank_routing_num = txtRoutingNumber.Value;

                                achResponse = acctServicesCC.set_pay_method_bank_draft(achRequest);
                                divChangesMessage.Visible = true;
                                if (achResponse.error_code != 0)
                                {
                                    litChangesMessage.Text = achResponse.error_msg;
                                }
                                else
                                {
                                    updated = true;
                                    litChangesMessage.Text = " Your changes have been saved. ";
                                }
                            }
                            break;
                        default:
                            script += "hide21('ACH'); hide21('Ccard'); hide21('cc_details');";
                            set_pay_method_net_termsRequest netTermsRequest = new set_pay_method_net_termsRequest();

                            set_pay_method_net_termsResponse netTermsResponse = null;
                            netTermsRequest.account_no = SessionSupport.CurrentAccountNumber;
                            netTermsRequest.auth_key = ConfigFactory.GetAriaAuthorizationKey();
                            netTermsRequest.client_no = ConfigFactory.GetAriaClientNumber();
                            netTermsRequest.pay_method = long.Parse(ddlPayTypes.SelectedValue);

                            netTermsResponse = acctServicesCC.set_pay_method_net_terms(netTermsRequest);
                            divChangesMessage.Visible = true;
                            if (netTermsResponse.error_code != 0)
                            {
                                litChangesMessage.Text = netTermsResponse.error_msg;
                            }
                            else
                            {
                                updated = true;
                                litChangesMessage.Text = " Your changes have been saved. ";
                            }
                            break;
                    }

                    Page.ClientScript.RegisterStartupScript(typeof(Page),
                                                            Guid.NewGuid().ToString(),
                                                            script,
                                                            true);

                    get_acct_details_allRequest acctRequest = new get_acct_details_allRequest();
                    get_acct_details_allResponse acctResponse = null;

                    acctRequest.acct_no = SessionSupport.CurrentAccountNumber;
                    acctRequest.auth_key = ConfigFactory.GetAriaAuthorizationKey();
                    acctRequest.client_no = ConfigFactory.GetAriaClientNumber();

                    acctResponse = acctServicesCC.get_acct_details_all(acctRequest);
                    BindPaymentMethod(acctResponse);
                }
            }
            catch (Exception exc)
            {
                throw new Exception("Error occurred saving payment",
                                    exc);
            }
        }

        // lbtnSubmitBilling_Click

        ///--------------------------------------------------------------------------
        /// <summary>
        /// Handles the ddlCountry's selected index changed event. It is responsible
        /// for setting up the state entry based on the selected Country.
        /// </summary>
        ///--------------------------------------------------------------------------
        protected void ddlCountry_SelectedIndexChanged(object sender,
                                                       EventArgs e)
        {
            try
            {
                divChangesMessage.Visible = false;
                string selectedCountry = ddlCountry.SelectedValue;

                litLocalityTitle.Text = ucState.ShowStates(ddlCountry.SelectedValue,
                                                           "");
                switch (selectedCountry)
                {
                    case "US":
                        rfvZipCode.Enabled = true;
                        revUSCAPhone.Enabled = true;
                        revIntlPhone.Enabled = false;
                        break;
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

                Page.ClientScript.RegisterStartupScript(typeof(Page),
                                                        Guid.NewGuid().ToString(),
                                                        "javascript:toggleTabs('tab1');openEditor('company'); show21('info_section_edit_link1_company');" + GetBillingScript(),
                                                        true);
            }
            catch (Exception exc)
            {
                throw new Exception("Error occurred changing the country",
                                    exc);
            }
        }

        ///--------------------------------------------------------------------------
        /// <summary>
        /// Handles the ddlBillingCountry's selected index changed event. It is responsible
        /// for setting up the state entry based on the selected Country.
        /// </summary>
        ///--------------------------------------------------------------------------
        protected void ddlBillingCountry_SelectedIndexChanged(object sender,
                                                              EventArgs e)
        {
            string state;

            try
            {
                divChangesMessage.Visible = false;
                string selectedCountry = ddlBillingCountry.SelectedValue;
                litBillingLocalityLabel.Text = ucBillingState.ShowStates(selectedCountry,
                                                                         "");

                Page.ClientScript.RegisterStartupScript(typeof(Page),
                                                        Guid.NewGuid().ToString(),
                                                        "javascript:toggleTabs('tab3'); openEditor('billing'); show21('info_section_edit_link1_billing');show21('Ccard'); hide21('ACH');",
                                                        true);
            }
            catch (Exception exc)
            {
                throw new Exception("Error occurred changing the country",
                                    exc);
            }
        }

        ///--------------------------------------------------------------------------
        /// <summary>
        /// Provides the event handler for the current password validate click event
        /// </summary>
        /// 
        /// <param name="sender">Set to the sender of the event</param>
        /// <param name="e">Set to the event arguments</param>
        protected void currentPassword_ServerValidate(object sender,
                                                      ServerValidateEventArgs e)
        {
            if (!txtCurrentPassword.Value.Trim().Equals(SessionSupport.CurrentCredential))
            {
                e.IsValid = false;
            }
        }

        ///--------------------------------------------------------------------------
        /// <summary>
        /// Provides the event handler for the expiry year validate click event
        /// </summary>
        /// 
        /// <param name="sender">Set to the sender of the event</param>
        /// <param name="e">Set to the event arguments</param>
        protected void ccYear_ServerValidate(object sender,
                                             ServerValidateEventArgs e)
        {
            DateTime expiry = new DateTime(Convert.ToInt32(ddlYear.SelectedValue),
                                           Convert.ToInt32(ddlMonth.SelectedValue),
                                           DateTime.DaysInMonth(Convert.ToInt32(ddlYear.SelectedValue),
                                                                Convert.ToInt32(ddlMonth.SelectedValue)));

            if (DateTime.Now > expiry)
            {
                e.IsValid = false;
            }

            Page.ClientScript.RegisterStartupScript(typeof(Page),
                                                    Guid.NewGuid().ToString(),
                                                    "javascript:toggleTabs('tab3'); openEditor('billing'); show21('info_section_edit_link1_billing');show21('Ccard'); hide21('ACH');",
                                                    true);
        }

        ///--------------------------------------------------------------------------
        /// <summary>
        /// Provides the event handler for the cc number validate click event
        /// </summary>
        /// 
        /// <param name="sender">Set to the sender of the event</param>
        /// <param name="e">Set to the event arguments</param>
        protected void ccNumber_ServerValidate(object sender,
                                               ServerValidateEventArgs e)
        {
            e.IsValid = true;

            if (txtCCNumber.Value.Substring(0,
                                            1) != "3" &&
                txtCCNumber.Value.Substring(0,
                                            1) != "4" &&
                txtCCNumber.Value.Substring(0,
                                            1) != "5" &&
                txtCCNumber.Value.Substring(0,
                                            1) != "6")
            {
                e.IsValid = false;
                (sender as CustomValidator).ErrorMessage = "Unidentified card number. Please re-enter";
            }
            else if (txtCCNumber.Value.Trim().Length != 16 &&
                     txtCCNumber.Value.Substring(0,
                                                 1) == "4" &&
                     txtCCNumber.Value.Substring(0,
                                                 1) == "5" &&
                     txtCCNumber.Value.Substring(0,
                                                 1) == "6")
            {
                e.IsValid = false;
                (sender as CustomValidator).ErrorMessage = "Visa, MasterCard and Discover card numbers must be 16 digits";
            }
            else if (txtCCNumber.Value.Trim().Length != 15 &&
                     txtCCNumber.Value.Substring(0,
                                                 1) == "3")
            {
                e.IsValid = false;
                (sender as CustomValidator).ErrorMessage = "Amex card numbers must be 15 digits";
            }
            else if (txtCCNumber.Value.Trim().Length != 15 &&
                     txtCCNumber.Value.Trim().Length != 16)
            {
                e.IsValid = false;
                (sender as CustomValidator).ErrorMessage = "Amex card numbers must be 15 digits. Visa, MasterCard & Discover card numbers must be 16 digits.";
            }

            Page.ClientScript.RegisterStartupScript(typeof(Page),
                                                    Guid.NewGuid().ToString(),
                                                    "javascript:toggleTabs('tab3'); openEditor('billing'); show21('info_section_edit_link1_billing');show21('Ccard'); hide21('ACH');",
                                                    true);
        }

        ///--------------------------------------------------------------------------
        /// <summary>
        /// Handles the ddlPayTypes's selected index changed event. 
        /// </summary>
        ///--------------------------------------------------------------------------
        protected void ddlPayTypes_SelectedIndexChanged(object sender,
                                                        EventArgs e)
        {
            string script = "javascript:toggleTabs('tab3'); openEditor('billing'); show21('info_section_edit_link1_billing');";
            try
            {
                divChangesMessage.Visible = false;
                script += GetBillingScript();

                Page.ClientScript.RegisterStartupScript(typeof(Page),
                                                        Guid.NewGuid().ToString(),
                                                        script,
                                                        true);
            }
            catch (Exception exc)
            {
                throw new Exception("Error occurred changing the payment type",
                                    exc);
            }
        }

        private string GetBillingScript()
        {
            string script = "";
            switch (ddlPayTypes.SelectedValue)
            {
                case "1":
                    script = "show21('Ccard'); hide21('ACH');";
                    break;
                case "2":
                    script = "hide21('Ccard'); hide21('cc_details'); show21('ACH');";
                    break;
                default:
                    script = "hide21('Ccard'); hide21('cc_details'); hide21('ACH');";
                    break;
            }
            return script;
        }

        ///--------------------------------------------------------------------------
        /// <summary>
        /// Handles the chkUseResidence button's checkedchanged event. It is responsible for 
        /// populating the billing address form with values from account
        /// </summary>
        ///--------------------------------------------------------------------------
        protected void chkUseResidence_CheckedChanged(object sender,
                                                      EventArgs e)
        {
            if (chkUseResidence.Checked)
            {
                txtBillingAddress1.Value = txtAddress1.Value;
                txtBillingAddress2.Value = txtAddress2.Value;
                txtBillingCity.Value = txtCity.Value;
                ddlBillingCountry.SelectedValue = ddlCountry.SelectedValue;

                ucBillingState.ShowStates(ddlBillingCountry.SelectedValue,
                                          ucState.GetCurrentState());
                txtBillingZipCode.Value = txtZipCode.Value;
            }

            Page.ClientScript.RegisterStartupScript(typeof(Page),
                                                    Guid.NewGuid().ToString(),
                                                    "javascript:toggleTabs('tab3'); openEditor('billing'); show21('info_section_edit_link1_billing');show21('Ccard'); hide21('ACH');",
                                                    true);
        }

        // chkUseResidence_CheckedChanged

        private readonly string[] mSecretQuestions = {
                                                   "Choose a question",
                                                   "What was the name of your first pet?",
                                                   "What was the name of your childhood best friend?",
                                                   "What was your childhood hero?",
                                                   "What was the name of your elementary school?",
                                                   "What was your high school mascot?"
                                                 };

        private void InitializeForm(long account_no)
        {
            using (AriaBillingComplete acctServices = new AriaBillingComplete())
            {
                //use the using block so that dispose is called. In dispose the connection in closed.
                get_acct_details_allRequest acctRequest = new get_acct_details_allRequest();
                get_acct_details_allResponse acctResponse = null;

                acctRequest.acct_no = account_no;
                acctRequest.auth_key = ConfigFactory.GetAriaAuthorizationKey();
                acctRequest.client_no = ConfigFactory.GetAriaClientNumber();

                acctResponse = acctServices.get_acct_details_all(acctRequest);

                #region AccountInfo

                BindAccountInfo(acctResponse);

                #endregion

                #region Plan Info

                litPlanName.Text = acctResponse.plan_name;

                get_client_plans_allRequest plansRequest = new get_client_plans_allRequest();
                get_client_plans_allResponse plansResponse = null;

                plansRequest.auth_key = ConfigFactory.GetAriaAuthorizationKey();
                plansRequest.client_no = ConfigFactory.GetAriaClientNumber();

                plansResponse = acctServices.get_client_plans_all(plansRequest);

                ddlAllPlans.DataSource = plansResponse.all_client_plans;
                ddlAllPlans.DataBind();

                ddlAllPlans.SelectedValue = acctResponse.plan_no;

                #endregion

                #region Payment Method

                BindPaymentMethod(acctResponse);

                #endregion

                #region Transaction History

                get_acct_trans_historyResponse historyResponse = null;

                get_acct_trans_historyRequest historyRequest = new get_acct_trans_historyRequest
                    {
                        account_no = account_no,
                        auth_key = ConfigFactory.GetAriaAuthorizationKey(),
                        client_no = ConfigFactory.GetAriaClientNumber()
                    };

                historyResponse = acctServices.get_acct_trans_history(historyRequest);
                foreach (history_ReturnElement elem in historyResponse.history)
                {
                    if (elem.transaction_applied_amount==null)
                    {
                        elem.transaction_applied_amount = 0;
                    }
                }
                gvTransactions.DataSource = historyResponse.history;
                gvTransactions.DataBind();

                #endregion
            }
        }

        private void BindAccountInfo(get_acct_details_allResponse acctResponse)
        {
            ddlCountry.SelectedValue = acctResponse.country;
            string state = "";
            if (!string.IsNullOrEmpty(acctResponse.state_prov))
            {
                state = acctResponse.state_prov;
            }
            else if (!string.IsNullOrEmpty(acctResponse.locality))
            {
                state = acctResponse.locality;
            }

            litLocalityTitle.Text = ucState.ShowStates(acctResponse.country,
                                                       state);

            litFullName.Text = acctResponse.first_name + " " + acctResponse.last_name;
            litWelcomeFullName.Text = litFullName.Text;
            litUserId.Text = acctResponse.userid;
            int intVal;
            if (int.TryParse(acctResponse.secret_question,
                             out intVal) &&
                intVal < mSecretQuestions.Length)
            {
                litSecretQuestion.Text = mSecretQuestions[intVal];
            }

            litYourAnswer.Text = acctResponse.secret_question_answer;
            litAddress.Text = acctResponse.address1;
            if (!string.IsNullOrEmpty(acctResponse.address2))
            {
                litAddress.Text += "<br/>" + acctResponse.address2;
            }
            litAddress.Text += "<br/>" + acctResponse.city + ", " + state + " " + acctResponse.postal_code + "<br/>";
            litAddress.Text += acctResponse.country + "<br/>";
            litPhone.Text = acctResponse.intl_phone;
            litEmail.Text = acctResponse.alt_email;

            txtFirstName.Value = acctResponse.first_name;
            txtLastName.Value = acctResponse.last_name;
            txtUserId.Value = acctResponse.userid;
            txtAddress1.Value = acctResponse.address1;
            txtAddress2.Value = acctResponse.address2;
            txtCity.Value = acctResponse.city;
            txtZipCode.Value = acctResponse.postal_code;

            txtPhone.Value = acctResponse.intl_phone;
            txtEmail.Value = acctResponse.alt_email;

            switch (acctResponse.country)
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

        private void BindPaymentMethod(get_acct_details_allResponse acctResponse)
        {
            string script = "javascript:";

            ddlPayTypes.SelectedValue = acctResponse.pay_method;

            switch (acctResponse.pay_method)
            {
                case "1":
                    script += "show21('Ccard'); hide21('ACH');";
                    divCCPayMethod.Visible = true;
                    divACHPayMethod.Visible = false;
                    divOtherPayMethod.Visible = false;
                    Ccard.Attributes["style"] = "display: ";
                    ACH.Attributes["style"] = "display:none";
                    litCCPayMethodName.Text = acctResponse.pay_method_name;
                    litCCSuffix.Text = acctResponse.cc_suffix;
                    litExpiresOn.Text = acctResponse.cc_expire_mm + "/" + acctResponse.cc_expire_yyyy;
                    litBillingFullName.Text = acctResponse.billing_first_name + " " + acctResponse.billing_last_name;

                    string billingState = "";
                    if (!string.IsNullOrEmpty(acctResponse.billing_state))
                    {
                        billingState = acctResponse.billing_state;
                    }
                    else if (!string.IsNullOrEmpty(acctResponse.billing_locality))
                    {
                        billingState = acctResponse.billing_locality;
                    }
                    litBillingAddress.Text = acctResponse.billing_address1;
                    if (!string.IsNullOrEmpty(acctResponse.billing_address2))
                    {
                        litBillingAddress.Text += " " + acctResponse.billing_address2;
                    }
                    litBillingAddress.Text += "<br/>" + acctResponse.billing_city + ", " + billingState + " " + acctResponse.billing_zip + "<br/>";
                    litBillingAddress.Text += acctResponse.billing_country + "<br/>";

                    txtCCNumber.Value = "xxxx-xxxx-xxxx-" + acctResponse.cc_suffix;
                    ddlMonth.SelectedValue = acctResponse.cc_expire_mm;
                    ddlYear.SelectedValue = acctResponse.cc_expire_yyyy;
                    txtBillingFirstName.Value = acctResponse.billing_first_name;
                    txtBillingLastName.Value = acctResponse.billing_last_name;
                    txtBillingAddress1.Value = acctResponse.billing_address1;
                    txtBillingAddress2.Value = acctResponse.billing_address2;
                    txtBillingCity.Value = acctResponse.billing_city;
                    txtBillingZipCode.Value = acctResponse.billing_zip;
                    ddlBillingCountry.SelectedValue = acctResponse.billing_country;
                    ucBillingState.ShowStates(acctResponse.billing_country,
                                              billingState);

                    break;
                case "2":
                    script += "hide21('Ccard'); hide21('cc_details'); show21('ACH');";
                    divCCPayMethod.Visible = false;
                    divACHPayMethod.Visible = true;
                    divOtherPayMethod.Visible = false;
                    Ccard.Attributes["style"] = "display:none";
                    ACH.Attributes["style"] = "display: ";
                    litACHPayMethodName.Text = acctResponse.pay_method_name;
                    litRoutingNumber.Text = acctResponse.bank_routing_no;
                    litBankNumber.Text = acctResponse.bank_acct_suffix;

                    txtRoutingNumber.Value = acctResponse.bank_routing_no;
                    txtBankAccountNumber.Value = "xxxxxxxx-" + acctResponse.bank_acct_suffix;
                    break;
                default:

                    if (ddlPayTypes.Items.FindByValue(acctResponse.pay_method) != null)
                    {
                        script += "hide21('Ccard'); hide21('cc_details'); hide21('ACH');";
                    }
                    else
                    {
                        script += "show21('Ccard'); hide21('ACH');";

                    }

                    divCCPayMethod.Visible = false;
                    divACHPayMethod.Visible = false;
                    divOtherPayMethod.Visible = true;
                    litOtherPayMethodName.Text = acctResponse.pay_method_name;
                    break;
            }

            PayMethodScript = script;
            Page.ClientScript.RegisterStartupScript(typeof(Page),
                                                    Guid.NewGuid().ToString(),
                                                    script + "closeEditor('billing');",
                                                    true);
        }
    }
}