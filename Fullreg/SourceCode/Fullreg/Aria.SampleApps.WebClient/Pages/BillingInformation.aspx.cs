// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BillingInformation.aspx.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Billing Information Page
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
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
    public partial class BillingInformation :
        MvpBasePage<BillingInformationPresenter, IBillingInformationView>, IBillingInformationView
    {
        #region Properties

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

        public string SessionId
        {
            get
            {
                if(Session["SessionId"] == null)
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

        public Dictionary<string, string> CountryList
        {
            set
            {
                countrybillingpageDropDownList.DataSource = value;
                countrybillingpageDropDownList.DataValueField = "Key";
                countrybillingpageDropDownList.DataTextField = "Value";
                countrybillingpageDropDownList.DataBind();
            }
        }

        public AccountCompleteDto AccountComplete
        {
            get
            {
                return ViewState["AccountComplete"] as AccountCompleteDto;
            }
            set
            {
                ViewState["AccountComplete"] = value;
            }
        }

        public bool ComfirmAccountInfo
        {
            get
            {
                return ViewState["ComfirmAccountInfo"] == null ? false : (bool)ViewState["ComfirmAccountInfo"];
            }
            set
            {
                ViewState["ComfirmAccountInfo"] = value;
            }
        }

        public string Name
        {
            get
            {
                return billingnamTexBox.Text + billingnamTextBox2.Text;
            }
            set
            {
                billingnamTexBox.Text = value;
            }
        }

        public string Country
        {
            get
            {
                return countrybillingpageDropDownList.SelectedValue;
            }
            set
            {
                countrybillingpageDropDownList.SelectedValue =  value;
            }
        }

        public string Adress
        {
            get
            {
                return billingaddressTextBox.Text;
            }
            set
            {
                billingaddressTextBox.Text = value;
            }
        }
    
        public string Adress2
        {
            get
            {
                return billingaddressTextBox2.Text;
            }
            set
            {
                billingaddressTextBox2.Text = value;
            }
        }

        public string CityTown
        {
            get
            {
                return citytownbillingpageTextBox.Text;
            }
            set
            {
                citytownbillingpageTextBox.Text = value;
            }
        }

        public string Locality
        {
            get
            {
                return billlocalityTextBox.Text;
            }
            set
            {
                billlocalityTextBox.Text = value;
            }
        }

        public string ZipCode
        {
            get
            {
                return zipcodebillingpageTextBox.Text;
            }
            set
            {
                zipcodebillingpageTextBox.Text = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phonenumberbillingpageTextBox.Text;
            }
            set
            {
                phonenumberbillingpageTextBox.Text = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return billingcompanynameTextBox.Text;
            }
            set
            {
                billingcompanynameTextBox.Text = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                return invoicebillingemailTextBox.Text;
            }
            set
            {
                invoicebillingemailTextBox.Text = value;
            }
        }

        #endregion

        #region Methods

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
                    AccountComplete = Session["AccountComplete"] as AccountCompleteDto;
                    Session["AccountComplete"] = null;

                    // if coming from the confirm account page
                    if (Session["ConfirmAccountInfo"] != null)
                    {
                        ComfirmAccountInfo = true; 
                        Session["ConfirmAccountInfo"] = null;
                        presenter.ValidateSession();

                        if (ValidateSessionDto.ValidSession)
                        {
                            Name = AccountComplete.BillingInfo.Name + " " + AccountComplete.BillingInfo.LastName;
                            CompanyName = AccountComplete.BillingInfo.CompanyName;
                            Adress = AccountComplete.BillingInfo.Address;
                            Adress2 = AccountComplete.BillingInfo.Address2;
                            CityTown = AccountComplete.BillingInfo.CityTown;
                            Country = AccountComplete.BillingInfo.Country;
                            Locality = AccountComplete.BillingInfo.Locality;
                            ZipCode = AccountComplete.BillingInfo.ZipCode;
                            PhoneNumber = AccountComplete.BillingInfo.PhoneNumber;
                            EmailAddress = AccountComplete.BillingInfo.EmailAddress;
                        }
                        else
                        {
                            MoveBackward(ARIASDKPages.CreateAccount);
                        }
                    }
                }
                else
                {
                    MoveBackward(ARIASDKPages.CreateAccount);
                }

                presenter.LoadDropDownLists();

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
            billinginformationLabel.Text = LabelsList["billinginformation"];
            billingaddressissameasmailingaddressLabel.Text = LabelsList["billingaddressissameasmailingaddress"];
            billingnameLabel.Text = LabelsList["billingname"];
            countrybillingpageLabel.Text = LabelsList["countrybillingpage"];
            billingaddressLabel.Text = LabelsList["billingaddress"];
            citytownbillingpageLabel.Text = LabelsList["citytownbillingpage"];
            billlocalityLabel.Text = LabelsList["billlocality"];
            zipcodebillingpageLabel.Text = LabelsList["zipcodebillingpage"];
            phonenumberbillingpageLabel.Text = LabelsList["phonenumberbillingpage"];
            billingcompanynameLabel.Text = LabelsList["billingcompanyname"];
            invoicebillingemailLabel.Text = LabelsList["invoicebillingemail"];

            //validators
            var requiered = LabelsList["required"];
            acountrybillingpageDropDownListRequiredFieldValidator.ErrorMessage = requiered;
            billingaddressTextBoxRequiredFieldValidator.ErrorMessage = requiered;
            citytownbillingpageTextBoxRequiredFieldValidator.ErrorMessage = requiered;
            billlocalityTextBoxRequiredFieldValidator.ErrorMessage = requiered;
            zipcodebillingpageTextBoxRequiredFieldValidator.ErrorMessage = requiered;
            phonenumberTextBoxRequiredFieldValidator.ErrorMessage = requiered;
            billingcompanynameTextBoxRequiredFieldValidator.ErrorMessage = requiered;
            invoicebillingemailTextBoxRequiredFieldValidator.ErrorMessage = requiered;
        }

        /// <summary>
        /// Handles the Click event of the BackButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void BackButton_Click(object sender, EventArgs e)
        {
            Session["AccountComplete"] = AccountComplete;

            if (ComfirmAccountInfo)
            {
                // if coming from the confirm account page then mark the account as edited
                Session["Edited"] = true;
            }
            
            MoveBackward(ComfirmAccountInfo ? ARIASDKPages.Confirm : ARIASDKPages.CreateAccount);
        }

        /// <summary>
        /// Handles the Click event of the NextButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void NextButton_Click(object sender, EventArgs e)
        {
            var billingInfoDto = new BillingInformationDto
                                     {
                                         Name = string.IsNullOrEmpty(Name) ? 
                                                AccountComplete.FirstName + " " + AccountComplete.LastName : Name,
                                         Country = Country,
                                         Address = Adress,
                                         Address2 = Adress2,
                                         CityTown = CityTown,
                                         Locality = Locality,
                                         ZipCode = ZipCode,
                                         PhoneNumber = PhoneNumber,
                                         CompanyName = CompanyName,
                                         EmailAddress = EmailAddress
                                     };

            AccountComplete.BillingInfo = billingInfoDto;
            Session["AccountComplete"] = AccountComplete;

            if (ComfirmAccountInfo) // If the page is then confirm the account already exists, must be updated
            {
                presenter.UpdateBillingInformation();

                if (ComfirmAccountInfo)
                {
                    Session["Edited"] = true;
                }
                
                MoveForward();
            }
            
            MoveForward();
        }

        /// <summary>
        /// Handles the CheckedChanged event of the SameAsMailingAddressCheckBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void SameAsMailingAddressCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var chekcBox = sender as CheckBox;

            if(chekcBox.Checked)
            {
                Name = AccountComplete.FirstName + " " + AccountComplete.LastName;
                CompanyName = AccountComplete.CompanyName;
                Adress = AccountComplete.StreetAddress;
                Adress2 = AccountComplete.StreetAddress2;
                CityTown = AccountComplete.CityTown;
                Country = AccountComplete.Country;
                Locality = AccountComplete.Locality;
                ZipCode = AccountComplete.ZipCode;
                PhoneNumber = AccountComplete.PhoneNumber;
                EmailAddress = AccountComplete.EmailAddress;
            }
        }

        #endregion
    }
}
