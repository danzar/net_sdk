// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConfirmAccountInformation.aspx.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
// Confirm Account Information Page
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
                countryLabel.Text = value.Country;
                zipCodeLabel.Text = value.ZipCode;
                phoneLabel.Text = value.PhoneNumber;
                emailLabel.Text = value.EmailAddress;
                userIdLabel.Text = value.UserId;
                securityQuestionLabel2.Text = value.SecurityQuestion;
                securityanswer2Label.Text = value.Answer;
                stateProvinceLocalityLabel.Text = value.Locality;
            }
            get
            {
                return ViewState["AccountComplete"] as AccountCompleteDto;
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
                }
                else
                {
                    Response.Redirect("RegisterNewAccount.aspx");
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
            reviewacctinformationLabel.Text = LabelsList["reviewacctinformation"];
            instructionsreviewacctinfoLabel.Text = LabelsList["instructionsreviewacctinfo"];
            createAccountButton.Text = LabelsList["createaccount"];

            //AccountInfo
            invoiceeditAccountLinkButton.Text = LabelsList["editaccount"];
            invoiceaccountnameLabel.Text = LabelsList["invoiceaccountname"];
            invoiceaccountcompanyLabel.Text = LabelsList["invoiceaccountcompany"];
            invoiceaccountaddressLabel.Text = LabelsList["invoiceaccountaddress"];
            invoiceaccountphoneLabel.Text = LabelsList["invoiceaccountphone"];
            invoiceaccountemailLabel.Text = LabelsList["invoiceaccountemail"];
            invoiceaccountuseridLabel.Text = LabelsList["invoiceaccountuserid"];
            passwordLabel.Text = LabelsList["password"];
            securityquestionLabel.Text = LabelsList["securityquestion"];
            securityanswerLabel.Text = LabelsList["securityanswerbillingpage"];
        }

        /// <summary>
        /// Handles the Click event of the NextButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void CreateAccountButton_Click(object sender, EventArgs e)
        {
            presenter.CreateAcccountComplete();
            reviewacctinformationLabel.Text = LabelsList["congratulations"];
            instructionsreviewacctinfoLabel.Text = LabelsList["instructionsyouraccthasbeencreated"];
            createAccountButton.Visible = false;
            infoItemDiv.Visible = false;
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
            Response.Redirect("RegisterNewAccount.aspx");
        }

        #endregion
    }
}