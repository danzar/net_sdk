// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfirmAccountInformation.aspx.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Confirm Account Information Page
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aria.SampleApps.Common.Dto;
using Aria.SampleApps.Common.Enum;
using Aria.SampleApps.Common.Web;
using Aria.SampleApps.WebClient.Shell.Presenters;
using Aria.SampleApps.WebClient.Shell.Views;

namespace ARIA.Pages
{
    public partial class ConfirmAccountInformation :
        MvpBasePage<ConfirmAccountInformationPresenter, IConfirmAccountInformationView>, IConfirmAccountInformationView
    {

        #region Properties

        /// <summary>
        /// Gets or sets the labels list.
        /// </summary>
        /// <value>The labels list.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public Dictionary<string, string> LabelsList
        {
            get
            {
                return Cache["LabelsList"] == null ?
                    null : Cache["LabelsList"] as Dictionary<string, string>;
            }
            set
            {
                Cache["LabelsList"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the account complete dto.
        /// </summary>
        /// <value>The account complete dto.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public AccountCompleteDto AccountCompleteDto
        {
            set
            {
                ViewState["AccountComplete"] = value;

                //Account Info
                nameLabel.Text = value.FirstName + " " + value.LastName;
                companyLabel.Text = value.CompanyName;
                addressLabel.Text = value.StreetAddress;
                address2Label.Text = value.StreetAddress2;
                cityLabel.Text = value.CityTown;
                stateLabel.Text = value.Locality;
                countryLabel.Text = value.Country;
                zipCodeLabel.Text = value.ZipCode;
                phoneLabel.Text = value.PhoneNumber;
                emailLabel.Text = value.EmailAddress;
                userIdLabel.Text = value.UserId;

                //BillingInfo
                billingNameLabel.Text = value.BillingInfo.Name;
                billingCompanyLabel.Text = value.BillingInfo.CompanyName;
                billingAddressLabel.Text = value.BillingInfo.Address;
                billingAddress2Label.Text = value.BillingInfo.Address2;
                billingCityLabel.Text = value.BillingInfo.CityTown;
                billintStateLabel.Text = value.BillingInfo.Locality;
                billingCountryLabel.Text = value.BillingInfo.Country;
                billingZipCodeLabel.Text = value.BillingInfo.ZipCode;
                billingPhoneLabel.Text = value.BillingInfo.PhoneNumber;
                billingEmailLabel.Text = value.BillingInfo.EmailAddress;

                //PlanInfo
                masterPlanDescLabel.Text = value.MasterPlan.Name + " (" + LabelsList["invoiceunits"] + ": " + value.MasterPlan.Units + ")";
                suppPlansListView.DataSource = value.SupplementalPlans;
                suppPlansListView.DataBind();

                //SummaryPlanInfo
                masterPlanSummaryNameLabel.Text = value.MasterPlan.Name;
                masterPlanSummaryDescriptionLabel.Text = value.MasterPlan.Description;
                masterPlanSummaryUnitsLabel.Text = value.MasterPlan.Units.ToString();
                masterPlanSummaryPriceLabel.Text = value.MasterPlan.Price.ToString();
                masterPlanSummaryAmountLabel.Text = (value.MasterPlan.Units * value.MasterPlan.Price).ToString();
                suppPlansSummaryListView.DataSource = value.SupplementalPlans;
                suppPlansSummaryListView.DataBind();
                var totalSupp = (from suppP in value.SupplementalPlans
                                 select suppP.Price * suppP.Units).Sum();
                                                        totalLabel.Text = (totalSupp + value.MasterPlan.Price * value.MasterPlan.Units).ToString();
            }
            get
            {
                return ViewState["AccountComplete"] as AccountCompleteDto;
            }
        }

        /// <summary>
        /// Gets or sets the session id.
        /// </summary>
        /// <value>The session id.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public string SessionId
        {
            get
            {
                if (Session["SessionId"] == null)
                {
                    return string.Empty;
                }

                return Session["SessionId"].ToString();
            }
            set
            {
                Session["SessionId"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the validate session dto.
        /// </summary>
        /// <value>The validate session dto.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public ValidateSessionDto ValidateSessionDto
        {
            get
            {
                if (ViewState["ValidateSessionDto"] == null)
                {
                    return new ValidateSessionDto { ValidSession = false };
                }

                return ViewState["ValidateSessionDto"] as ValidateSessionDto;
            }
            set
            {
                ViewState["ValidateSessionDto"] = value;
            }
        }

        #endregion

        #region Operations

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["AccountComplete"] != null)
                {
                    AccountCompleteDto = Session["AccountComplete"] as AccountCompleteDto;
                    Session["AccountComplete"] = null;

                    if (Session["Edited"] == null)
                    {
                        // If is a new account must be created
                        presenter.CreateAcccountComplete();
                    }
                    else
                    {
                        // If the account was edited on another page.
                        Session["Edited"] = null;
                        presenter.ValidateSession();

                        if (!ValidateSessionDto.ValidSession)
                        {
                            MoveBackward(ARIASDKPages.CreateAccount);
                        }
                    }
                }
                else
                {
                    MoveBackward(ARIASDKPages.CreateAccount);
                }

                if (LabelsList != null)
                {
                    LoadLabelsText();
                }
            }
        }

        /// <summary>
        /// Loads the labels text.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private void LoadLabelsText()
        {
            // Generals  
            acctinfoandinvoiceLabel.Text = LabelsList["acctinfoandinvoice"];
            nextButton.Text = LabelsList["next"];
            cancelButton.Text = LabelsList["cancelbutton"];

            //AccountInfo
            invoiceaccountheaderLabel.Text = LabelsList["invoiceaccountheader"];
            invoiceeditAccountLinkButton.Text = LabelsList["invoiceedit"];
            invoiceaccountnameLabel.Text = LabelsList["invoiceaccountname"];
            invoiceaccountcompanyLabel.Text = LabelsList["invoiceaccountcompany"];
            invoiceaccountaddressLabel.Text = LabelsList["invoiceaccountaddress"];
            invoiceaccountcityLabel.Text = LabelsList["invoiceaccountcity"];
            invoiceaccountstateLabel.Text = LabelsList["invoiceaccountstate"];
            invoiceaccountcountryLabel.Text = LabelsList["invoiceaccountcountry"];
            invoiceaccountzipLabel.Text = LabelsList["invoiceaccountzip"];
            invoiceaccountphoneLabel.Text = LabelsList["invoiceaccountphone"];
            invoiceaccountemailLabel.Text = LabelsList["invoiceaccountemail"];
            invoiceaccountuseridLabel.Text = LabelsList["invoiceaccountuserid"];

            //BillingInfo
            invoicebillingheaderLabel.Text = LabelsList["invoicebillingheader"];
            invoiceeditBillingInfoLinkButton.Text = LabelsList["invoiceedit"];
            invoicebillingnameLabel.Text = LabelsList["invoicebillingname"];
            invoicebillingcompanyLabel.Text = LabelsList["invoicebillingcompany"];
            invoicebillingaddressLabel.Text = LabelsList["invoicebillingaddress"];
            invoicebillingcityLabel.Text = LabelsList["invoicebillingcity"];
            invoicebillingstateLabel.Text = LabelsList["invoicebillingstate"];
            invoicebillingcountryLabel.Text = LabelsList["invoicebillingcountry"];
            invoicebillingzipLabel.Text = LabelsList["invoicebillingzip"];
            invoicebillingphoneLabel.Text = LabelsList["invoicebillingphone"];
            invoicebillingemailLabel.Text = LabelsList["invoicebillingemail"];

            //PlanInfo
            invoiceplanheaderLabel.Text = LabelsList["invoiceplanheader"];
            invoiceeditPlanLinkButton.Text = LabelsList["invoiceedit"];
            invoicemasterplanLabel.Text = LabelsList["invoicemasterplan"];
            invoicesupplementalplansLabel.Text = LabelsList["invoicesupplementalplans"];

            //SummaryPlanInfo
            invoiceblurbLabel.Text = LabelsList["invoiceblurb"];
            invoiceeditSumaryOfChargesLinkButton.Text = LabelsList["invoiceedit"];
            invoicemasterplanLabel2.Text = LabelsList["invoicemasterplan"];
            invoicedescriptionLabel.Text = LabelsList["invoicedescription"];
            invoiceunitsLabel.Text = LabelsList["invoiceunits"];
            invoicerateperunitLabel.Text = LabelsList["invoicerateperunit"];
            invoiceamountLabel.Text = LabelsList["invoiceamount"];
            invoicetotalLabel.Text = LabelsList["invoicetotal"];
        }

        /// <summary>
        /// Handles the Click event of the NextButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void NextButton_Click(object sender, EventArgs e)
        {
            Session["AccountComplete"] = AccountCompleteDto;
            MoveForward();
        }

        /// <summary>
        /// Handles the Click event of the CancelButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void CancelButton_Click(object sender, EventArgs e)
        {
            presenter.SuspendAccount();
            MoveBackward(ARIASDKPages.CreateAccount);
        }

        /// <summary>
        /// Edits the account.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void EditAccount(object sender, EventArgs e)
        {
            Session["AccountComplete"] = AccountCompleteDto;
            // this indicates to account creation page that account already exists and is being modified
            Session["ConfirmAccountInfo"] = 1;
            MoveBackward(ARIASDKPages.CreateAccount);
        }

        /// <summary>
        /// Edits the billing information.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void EditBillingInformation(object sender, EventArgs e)
        {
            Session["AccountComplete"] = AccountCompleteDto;
            // this indicates to billing page that account already exists and is being modified
            Session["ConfirmAccountInfo"] = 1;
            MoveBackward(ARIASDKPages.BillingInfo);
        }

        #endregion
    }
}