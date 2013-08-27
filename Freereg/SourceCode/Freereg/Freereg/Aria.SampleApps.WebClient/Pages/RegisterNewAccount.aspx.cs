// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegisterNewAccount.aspx.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Register New Account Page
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aria.SampleApps.Common.Dto;
using Aria.SampleApps.Common.Web;
using Aria.SampleApps.WebClient.Shell.Presenters;
using Aria.SampleApps.WebClient.Shell.Views;

namespace ARIA.Pages
{
    public partial class RegisterNewAccount : 
        MvpBasePage<RegisterNewAccountPresenter, IRegisterNewAccountView>, IRegisterNewAccountView
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

        // ************Account Info************
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

        public string FirstName
        {
            get
            {
                return firstnameTexBox.Text;
            }
            set
            {
                firstnameTexBox.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastnameTextBox.Text;
            }
            set
            {
                lastnameTextBox.Text = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return acctcompanynameTextBox.Text;
            }
            set
            {
                acctcompanynameTextBox.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return passwordTextBox.Text;
            }
            set
            {
                passwordTextBox.Attributes.Add("value", value);
                reenterpasswordTextBox.Attributes.Add("value", value);
            }
        }

        public string SecurityQuestion
        {
            get
            {
                return securityquestiondropDown.SelectedItem.Text;
            }
            set
            {
                securityquestiondropDown.SelectedValue = value;
            }
        }

        public string Answer
        {
            get
            {
                return youranswerTextBox.Text;
            }
            set
            {
                youranswerTextBox.Text = value;
            }
        }

        public string UserId
        {
            get
            {
                return useridTextBox.Text;
            }
            set
            {
                useridTextBox.Text = value;
            }
        }

        // ************Address Info************
        public string StreetAddress
        {
            get
            {
                return streetaddressTextBox.Text;
            }
            set
            {
                streetaddressTextBox.Text = value;
            }
        }

        public string StreetAddress2
        {
            get
            {
                return streetaddressTextBox2.Text;
            }
            set
            {
                streetaddressTextBox2.Text = value;
            }
        }

        public string CityTown
        {
            get
            {
                return citytownTextBox.Text;
            }
            set
            {
                citytownTextBox.Text = value;
            }
        }

        public string Country
        {
            get
            {
                return acctcountryDropDownList.SelectedValue;
            }
            set
            {
                acctcountryDropDownList.SelectedValue = value;
            }
        }

        public Dictionary<string,string> CountryList
        {
            set
            {
                value.Add("-1", LabelsList["selectcountry"]);
                acctcountryDropDownList.DataSource = value;
                acctcountryDropDownList.DataValueField = "Key";
                acctcountryDropDownList.DataTextField = "Value";
                acctcountryDropDownList.DataBind();
                acctcountryDropDownList.SelectedValue = "-1";
            }
        }

        public string Locality
        {
            get
            {
                return stateprovincelocalityTextBox.Text;
            }
            set
            {
                stateprovincelocalityTextBox.Text = value;
            }
        }
       
        public string ZipCode
        {
            get
            {
                return zipcodeTextBox.Text;
            }
            set
            {
                zipcodeTextBox.Text = value;
            }
        }

        // ************Contact Info************
        public string PhoneNumber
        {
            get
            {
                return phonenumberTextBox.Text;
            }
            set
            {
                phonenumberTextBox.Text = value;
            }
        }

        public string EmailAddress
        {
            get
            {
                return emailaddressTextBox.Text;
            }
            set
            {
                emailaddressTextBox.Text = value;
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
            if(!IsPostBack)
            {
                if(LabelsList == null)
                {
                    presenter.LoadLabelsList();
                }

                RegisterStatesProvinces();
                presenter.LoadDropDownLists();
                LoadLabelsText();

                if (Session["AccountComplete"] != null)
                {
                    AccountComplete = Session["AccountComplete"] as AccountCompleteDto;
                    Session["AccountComplete"] = null;
                    FirstName = AccountComplete.FirstName;
                    LastName = AccountComplete.LastName;
                    CompanyName = AccountComplete.CompanyName;
                    Password = AccountComplete.Password;
                    Answer = AccountComplete.Answer;
                    SecurityQuestion = AccountComplete.SecurityQuestion;
                    UserId = AccountComplete.UserId;
                    StreetAddress = AccountComplete.StreetAddress;
                    StreetAddress2 = AccountComplete.StreetAddress2;
                    CityTown = AccountComplete.CityTown;
                    Country = AccountComplete.Country;
                    Locality = AccountComplete.Locality;
                    ZipCode = AccountComplete.ZipCode;
                    PhoneNumber = AccountComplete.PhoneNumber;
                    EmailAddress = AccountComplete.EmailAddress;
                }
            }
        }

        /// <summary>
        /// Registers the states provinces.
        /// This method creates lists of states and provinces and puts them into a javascript 
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private void RegisterStatesProvinces()
        {
            var canadianProvinces = LabelsList.Where(l => l.Value.StartsWith("CA:")).ToList();
            var usStates = LabelsList.Where(l => l.Value.StartsWith("US:")).ToList();

            var script = new StringBuilder();
            script.Append("<script language='javascript'>");
            script.Append("var canadianProvinces = new Array(");

            foreach (var province in canadianProvinces)
            {
                script.Append('"');
                script.Append(province.Value);
                script.Append('"');
                script.Append(',');
            }

            script.Remove(script.Length - 1, 1);
            script.Append(");");
            script.Append("var usStates = new Array(");

            foreach (var state in usStates)
            {
                script.Append('"');
                script.Append(state.Value);
                script.Append('"');
                script.Append(',');
            }

            script.Remove(script.Length - 1, 1);
            script.Append(");");
            script.Append("</script>");

            Page.ClientScript.RegisterClientScriptBlock(GetType(), "LoadStateProvice", script.ToString());
        }

        /// <summary>
        /// Loads the labels text.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private void LoadLabelsText()
        {
            // Generals  
            registernewacctLabel.Text = LabelsList["registernewacct"];
            ifyoualreadyhaveacctLabel.Text = LabelsList["ifyoualreadyhaveacct"];
            signinhereLabel.Text = LabelsList["signinhere"];
            allfieldsarerequiredLabel.Text = LabelsList["allfieldsarerequired"];
            nextButton.Text = LabelsList["next"];

            // Account Info
            accountholderLabel.Text = LabelsList["accountholder"];
            firstnameLabel.Text = LabelsList["firstname"];
            lastnameLabel.Text = LabelsList["lastname"];
            acctcompanynameLabel.Text = LabelsList["acctcompanyname"];

            // Account Credentials
            accountcredentialsLabel.Text = LabelsList["accountcredentials"];
            useridLabel.Text = LabelsList["userid"];
            userIdCustomValidator.ErrorMessage = LabelsList["serveruseridexistsuserid"];
            useridTextBoxRegularExpressionValidator.ErrorMessage = LabelsList["jsaccepts450"];
            passwordLabel.Text = LabelsList["password"];
            reenterpasswordLabel.Text = LabelsList["reenterpassword"];
            securityquestionLabel.Text = LabelsList["securityquestion"];
            youranswerLabel.Text = LabelsList["youranswer"];

            // Adress Info
            addressLabel.Text = LabelsList["address"];
            streetaddressLabel.Text = LabelsList["streetaddress"];
            citytownLabel.Text = LabelsList["citytown"];
            acctcountryLabel.Text = LabelsList["acctcountry"];
            localityLabel.Text = LabelsList["billlocality"];
            proviceLabel.Text = LabelsList["billprovince"];
            stateLabel.Text = LabelsList["billstate"];
            zipcodeLabel.Text = LabelsList["zipcode"];
            
            // Contact Info
            contactinformationLabel.Text = LabelsList["contactinformation"];
            phonenumberLabel.Text = LabelsList["phonenumber"];
            emailaddressLabel.Text = LabelsList["emailaddress"];
            emailaddressTextBoxRegularExressionValidator.ErrorMessage = LabelsList["serveremailinvalid"];

            // Security Questions
            securityquestiondropDown.Items.Add(
                new ListItem(LabelsList["choosequestion"], "-1"));
            securityquestiondropDown.Items.Add(
                new ListItem(LabelsList["whatismothersmaidenname"], LabelsList["whatismothersmaidenname"]));
            securityquestiondropDown.Items.Add(
                new ListItem(LabelsList["whatcity"], LabelsList["whatcity"]));
            securityquestiondropDown.Items.Add(
                new ListItem(LabelsList["whatisfathersmiddlename"], LabelsList["whatisfathersmiddlename"]));
            securityquestiondropDown.Items.Add(
                new ListItem(LabelsList["whereattendhighschool"], LabelsList["whereattendhighschool"]));
            securityquestiondropDown.Items.Add(
                new ListItem(LabelsList["whatnamefirstpet"], LabelsList["whatnamefirstpet"]));
            securityquestiondropDown.Items.Add(
                new ListItem(LabelsList["whatfavoritefood"], LabelsList["whatfavoritefood"]));
        }

        /// <summary>
        /// Handles the Click event of the NextButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void NextButton_Click(object sender, EventArgs e)
        {
            if (presenter.UserIdExsist(UserId))
            {
                userIdCustomValidator.IsValid = false;
                return;
            }

            var newAccDto = new AccountCompleteDto
                                {
                                    FirstName = FirstName,
                                    LastName = LastName,
                                    CompanyName = CompanyName,
                                    Password = Password,
                                    SecurityQuestion = SecurityQuestion,
                                    Answer = Answer,
                                    UserId = UserId,
                                    StreetAddress = StreetAddress,
                                    StreetAddress2 = StreetAddress2,
                                    CityTown = CityTown,
                                    Country = Country,
                                    Locality = Locality,
                                    ZipCode = ZipCode,
                                    PhoneNumber = PhoneNumber,
                                    EmailAddress = EmailAddress
                                };

            Session["AccountComplete"] = newAccDto;
            Response.Redirect("ConfirmAccountInformation.aspx");
        }

        #endregion
    }
}