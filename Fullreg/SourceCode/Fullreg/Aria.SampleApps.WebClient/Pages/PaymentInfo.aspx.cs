// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PaymentInfo.aspx.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
// Payment Info Page
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aria.SampleApps.Common.Dto;
using Aria.SampleApps.Common.Enum;
using Aria.SampleApps.Common.Web;
using Aria.SampleApps.WebClient.Shell.Presenters;
using Aria.SampleApps.WebClient.Shell.Views;
using Settings = Aria.SampleApps.Common.Configuration.SampleAppsSettings;

namespace ARIA.Pages
{
    public partial class PaymentInfo : MvpBasePage<PaymentInfoPresenter, IPaymentInfoView>, IPaymentInfoView
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
        /// Gets or sets the account complete.
        /// </summary>
        /// <value>The account complete.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
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
                    return new ValidateSessionDto {ValidSession = false};
                }

                return ViewState["ValidateSessionDto"] as ValidateSessionDto;
            }
            set
            {
                ViewState["ValidateSessionDto"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the pay method.
        /// </summary>
        /// <value>The pay method.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private int? PayMethod
        {
            get
            {
                return ViewState["PayMethod"] == null ? null : (int?)ViewState["PayMethod"];
            }
            set
            {
                ViewState["PayMethod"] = value;
            }
        }

        /// <summary>
        /// Gets the credit card.
        /// </summary>
        /// <value>The credit card.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private CreditCardDto CreditCard
        {
            get
            {
                return new CreditCardDto
                           {
                               Number = long.Parse(cardNumberTextBox.Text),
                               ExpireMonth = int.Parse(monthDropDown.SelectedValue),
                               ExpireYear = int.Parse(yearDropDown.SelectedValue),
                               SecurityCode = long.Parse(securityCodeTextBox.Text)
                           };
            }
        }

        /// <summary>
        /// Gets the routing number.
        /// </summary>
        /// <value>The routing number.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private string RoutingNumber
        {
            get
            {
                return routingNumberTextBox.Text;
            }
        }

        /// <summary>
        /// Gets the account number.
        /// </summary>
        /// <value>The account number.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private string AccountNumber
        {
            get
            {
                return accNumberTextBox.Text;
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
                    presenter.ValidateSession();

                    if (!ValidateSessionDto.ValidSession)
                    {
                        MoveBackward(ARIASDKPages.CreateAccount);
                    }

                    if (LabelsList != null)
                    {
                        LoadLabelsText();
                    }
                    
                    LoadLists();
                    EnableValidators();
                }
                else
                {
                    MoveBackward(ARIASDKPages.CreateAccount);
                }
            }
        }

        /// <summary>
        /// Loads the labels text.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private void LoadLabelsText()
        {
            //General
            servermustselectpaymethodCustomValidator.ErrorMessage = LabelsList["servermustselectpaymethod"];
            confirmandenterbankinginfoLabel.Text = LabelsList["confirmandenterbankinginfo"];
            //Credit Card
            pbccLabel.Text = LabelsList["pbcc"];
            ccnumLabel.Text = LabelsList["ccnum"];
            expdateLabel.Text = LabelsList["expdate"];
            cvvLabel.Text = LabelsList["cvv"];
            whatisthisLinkButton.Text = LabelsList["whatisthis"];
            serverlengthofccnumberCustomValidator.ErrorMessage = LabelsList["serverlengthofccnumber"];
            serverinvalidccnumberCustomValidator.ErrorMessage = LabelsList["serverinvalidccnumber"];
            serverinvalidccnumberCustomValidator.ErrorMessage = LabelsList["servercvvhowmanydigits"];
            serverccexpiredCustomValidator.ErrorMessage = LabelsList["serverccexpired"];
            //ACH
            paybyachLabel.Text = LabelsList["paybyach"];
            achroutingnumLabel.Text = LabelsList["achroutingnum"];
            achacctnumLabel.Text = LabelsList["achacctnum"];
            //Net Terms
            payusingnettermsLabel.Text = LabelsList["payusingnetterms"];
            nextButton.Text = LabelsList["next"];
            //Validators
            var requiered = LabelsList["required"];
            cardNumberTextBoxRequiredFieldValidator.ErrorMessage = requiered;
            monthDropDownRequiredFieldValidator.ErrorMessage = requiered;
            yearDropDownRequiredFieldValidator.ErrorMessage = requiered;
            securityCodeTextBoxRequiredFieldValidator.ErrorMessage = requiered;
            routingNumberTextBoxRequiredFieldValidator.ErrorMessage = requiered;
            accNumberTextBoxRequiredFieldValidator.ErrorMessage = requiered;
        }

        /// <summary>
        /// Loads the lists.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private void LoadLists()
        {
            //NetTerms
            var list = new Dictionary<string, string>();
            list.Add(((int)PayMethodEnum.Net0).ToString(), LabelsList["payusingnet0"]);
            list.Add(((int)PayMethodEnum.Net10).ToString(), LabelsList["payusingnet10"]);
            list.Add(((int)PayMethodEnum.Net15).ToString(), LabelsList["payusingnet15"]);
            list.Add(((int)PayMethodEnum.Net30).ToString(), LabelsList["payusingnet30"]);
            list.Add(((int)PayMethodEnum.Net45).ToString(), LabelsList["payusingnet45"]);
            list.Add(((int)PayMethodEnum.Net60).ToString(), LabelsList["payusingnet60"]);
            netTermsListView.DataSource = list;
            netTermsListView.DataBind();

            //Month
            monthDropDown.Items.Add(new ListItem(LabelsList["month"], "-1"));
            monthDropDown.Items.Add(new ListItem(LabelsList["monthjan"], "01"));
            monthDropDown.Items.Add(new ListItem(LabelsList["monthfeb"], "02"));
            monthDropDown.Items.Add(new ListItem(LabelsList["monthmarch"], "03"));
            monthDropDown.Items.Add(new ListItem(LabelsList["monthapr"], "04"));
            monthDropDown.Items.Add(new ListItem(LabelsList["monthmay"], "05"));
            monthDropDown.Items.Add(new ListItem(LabelsList["monthjune"], "06"));
            monthDropDown.Items.Add(new ListItem(LabelsList["monthjuly"], "07"));
            monthDropDown.Items.Add(new ListItem(LabelsList["monthaug"], "08"));
            monthDropDown.Items.Add(new ListItem(LabelsList["monthsept"], "09"));
            monthDropDown.Items.Add(new ListItem(LabelsList["monthoct"], "10"));
            monthDropDown.Items.Add(new ListItem(LabelsList["monthnov"], "11"));
            monthDropDown.Items.Add(new ListItem(LabelsList["monthdec"], "12"));

            //Year
            int i=0;
            int year = DateTime.Now.Year;
            while (i<=15)
            {
                yearDropDown.Items.Add(new ListItem((year + i).ToString(), (year + i).ToString()));
                i++;
            }
        }

        

        /// <summary>
        /// Pays the by credit card radio button checked change.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void PayByCreditCardRadioButtonCheckedChange(object sender, EventArgs e)
        {
            // Set the credit card pay method
            PayMethod = (int)PayMethodEnum.CreditCard;
            EnableValidators();
            payByAchRadioButton.Checked = false;

            foreach (var item in netTermsListView.Items)
            {
                var netTermRadioButton = item.FindControl("netTermRadioButton") as RadioButton;
                netTermRadioButton.Checked = false;
            }
        }

        /// <summary>
        /// Pays the by ach radio button checked change.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void PayByAchRadioButtonCheckedChange(object sender, EventArgs e)
        {
            // Set the ACH pay method
            PayMethod = (int)PayMethodEnum.ACH;
            EnableValidators();
            payByCreditCardRadioButton.Checked = false;

            foreach (var item in netTermsListView.Items)
            {
                var netTermRadioButton = item.FindControl("netTermRadioButton") as RadioButton;
                netTermRadioButton.Checked = false;
            }
        }

        /// <summary>
        /// Nets the term raddio button checked canged.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void NetTermRaddioButtonCheckedCanged(object sender, EventArgs e)
        {
            var netTermRadioButton = sender as RadioButton;
            var listItem = netTermRadioButton.BindingContainer as ListViewItem;
            var netTermHiddenField = listItem.FindControl("netTermHiddenField") as HiddenField;
            var netTerm = netTermHiddenField.Value;
            // Set the net term pay method
            PayMethod = int.Parse(netTerm);
            EnableValidators();
            payByAchRadioButton.Checked = false;
            payByCreditCardRadioButton.Checked = false;
            payByAchRadioButton.Checked = false;

            foreach (var item in netTermsListView.Items)
            {
                var netTermRadioButton2 = item.FindControl("netTermRadioButton") as RadioButton;
                netTermRadioButton2.Checked = false;
            }

            netTermRadioButton.Checked = true;
        }

        /// <summary>
        /// Enables the validators.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private void EnableValidators()
        {
            var creditCard = PayMethod == (int) PayMethodEnum.CreditCard;
            var ach = PayMethod == (int) PayMethodEnum.ACH;

            //Credit Card Validators
            cardNumberTextBoxRequiredFieldValidator.Enabled = creditCard;
            monthDropDownRequiredFieldValidator.Enabled = creditCard;
            yearDropDownRequiredFieldValidator.Enabled = creditCard;
            securityCodeTextBoxRequiredFieldValidator.Enabled = creditCard;
            serverinvalidccnumberCustomValidator.Enabled = creditCard;

            //ACH Validators
            routingNumberTextBoxRequiredFieldValidator.Enabled = ach;
            routingNumberTextBoxCustomValidator.Enabled = ach;
            accNumberTextBoxRequiredFieldValidator.Enabled = ach;
            accNumberTextBoxCustomValidator.Enabled = ach;
        }

        /// <summary>
        /// Validates the pay methods.
        /// </summary>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private bool ValidatePayMethods()
        {
            servermustselectpaymethodCustomValidator.IsValid = true;
            serverlengthofccnumberCustomValidator.IsValid = true;
            serverinvalidccnumberCustomValidator.IsValid = true;
            serverccexpiredCustomValidator.IsValid = true;

            if (PayMethod != null)
            {
                if (PayMethod == (int) PayMethodEnum.CreditCard)
                {
                    return ValidateCreditCardPayment();
                }

                if (PayMethod == (int) PayMethodEnum.ACH)
                {
                    // All the validations for ach payment are implemented in ajaxtoolkit validators
                    return true;
                }

                if (PayMethod == (int)PayMethodEnum.Net0 || PayMethod == (int)PayMethodEnum.Net10 || PayMethod == (int)PayMethodEnum.Net15
                    || PayMethod == (int)PayMethodEnum.Net30 || PayMethod == (int)PayMethodEnum.Net45 || PayMethod == (int)PayMethodEnum.Net60)
                {
                    // All the validations for Net Method are implemented in ajaxtoolkit validators
                    return true;
                }
            }

            servermustselectpaymethodCustomValidator.IsValid = false;
            return false;
        }

        /// <summary>
        /// Validates the credit card payment.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private bool ValidateCreditCardPayment()
        {
            if (CreditCard.ExpireYear == DateTime.Now.Year && CreditCard.ExpireMonth < DateTime.Now.Month)
            {
                serverccexpiredCustomValidator.IsValid = false;
                return false;
            }

            string creditCardNumber = CreditCard.Number.ToString();
            int ccType = GetCardType(creditCardNumber);
            bool validCreditCard = ValidateCreditCardNumber(creditCardNumber);

            if (ccType == (int)CreditCardTypeEnum.INVALID)
            {
                serverlengthofccnumberCustomValidator.IsValid = false;
                return false;
            }

            if (!validCreditCard)
            {
                serverinvalidccnumberCustomValidator.IsValid = false;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Gets the card ID.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        /// returns the credit card type
        /// INVALID = -1;
        /// VISA = 0;
        /// MASTERCARD = 1;
        /// AMERICAN_EXPRESS = 2;
        /// EN_ROUTE = 3;
        /// DINERS_CLUB = 4;
        public static int GetCardType(string ccNumber)
        {
            int type = (int)CreditCardTypeEnum.INVALID;
            string digit1 = ccNumber.Substring(0, 1);
            string digit2 = ccNumber.Substring(0, 2);
            string digit3 = ccNumber.Substring(0, 3);
            string digit4 = ccNumber.Substring(0, 4);

            /* VISA prefix=4 length=13 or 16 (can be 15 too!?! maybe) */
            if (digit1.Equals("4"))
            {
                if (ccNumber.Length == 13 || ccNumber.Length == 16)
                {
                    type = (int)CreditCardTypeEnum.VISA;
                }
            }
            /* MASTERCARD prefix= 51 ... 55 - length= 16 */
            else if (digit2.CompareTo("51") >= 0 && digit2.CompareTo("55") <= 0)
            {
                if (ccNumber.Length == 16)
                {
                    type = (int)CreditCardTypeEnum.MASTERCARD;
                }
            }
            /* AMEX prefix=34 or 37 length=15 */
            else if (digit2.Equals("34") || digit2.Equals("37"))
            {
                if (ccNumber.Length == 15)
                {
                    type = (int)CreditCardTypeEnum.AMERICAN_EXPRESS;
                }
            }
            /* ENROU prefix=2014 or 2149 - length=15 */
            else if (digit4.Equals("2014") || digit4.Equals("2149"))
            {
                if (ccNumber.Length == 15)
                {
                    type = (int)CreditCardTypeEnum.EN_ROUTE;
                }
            }
            /* DCLUB prefix=300 ... 305 or 36 or 38 - length=14 */
            else if (digit2.Equals("36") || digit2.Equals("38") 
                || (digit3.CompareTo("300") >= 0 && digit3.CompareTo("305") <= 0))
            {
                if (ccNumber.Length == 14)
                {
                    type = (int)CreditCardTypeEnum.DINERS_CLUB;
                }
            }

            return type;
        }

        /// <summary>
        /// Validates the credit card number.
        /// </summary>
        /// <param name="number">The number.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private static bool ValidateCreditCardNumber(string number)
        {
            try
            {
                /* known as the LUHN Formula (mod10) */
                int j = number.Length;
                string[] s1 = new string[j];

                for (int i = 0; i < number.Length; i++)
                {
                    s1[i] = "" + number.ElementAt(i);
                }

                int checksum = 0;

                for (int i = s1.Length - 1; i >= 0; i -= 2)
                {
                    int k = 0;

                    if (i > 0)
                    {
                        k = int.Parse(s1[i - 1]) * 2;

                        if (k > 9)
                        {
                            string s = "" + k;
                            k = int.Parse(s.Substring(0, 1)) + int.Parse(s.Substring(1));
                        }

                        checksum += int.Parse(s1[i]) + k;
                    }
                    else
                    {
                        checksum += int.Parse(s1[0]);
                    }
                }

                return ((checksum % 10) == 0);
            }
            catch (Exception e)
            {
                var error = e.StackTrace.ToString();
                return false;
            }
        }
      
        /// <summary>
        /// Handles the Click event of the NextButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void NextButton_Click(object sender, EventArgs e)
        {
            if (ValidatePayMethods())
            {
                DirectPost();
                Session["AccountComplete"] = AccountComplete;
                MoveForward();
            }
        }

        /// <summary>
        /// Directs the post.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private void DirectPost()
        {
            Uri address = new Uri(Settings.Default.PaymentHandleUrl);

            // Create the web request  
            HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;

            // Set type to POST  
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            StringBuilder data = new StringBuilder();

            data.Append("formOfPayment=" + HttpUtility.UrlEncode(Enum.GetName(typeof(PayMethodEnum), PayMethod.Value)));
            data.Append("&inSessionID=" + HttpUtility.UrlEncode(SessionId));
            data.Append("&mode=" + HttpUtility.UrlEncode(Settings.Default.DirectPostRegMode));
            data.Append("&client_no=" + HttpUtility.UrlEncode(Settings.Default.client_no.ToString()));

            if (PayMethod == (int)PayMethodEnum.CreditCard)
            {
                data.Append("&cc_no=" + HttpUtility.UrlEncode(CreditCard.Number.ToString()));
                data.Append("&cc_exp_mm=" + HttpUtility.UrlEncode(CreditCard.ExpireMonth.ToString()));
                data.Append("&cc_exp_yyyy=" + HttpUtility.UrlEncode(CreditCard.ExpireYear.ToString()));
                data.Append("&cvv=" + HttpUtility.UrlEncode(CreditCard.SecurityCode.ToString()));
            }
            else if (PayMethod == (int)PayMethodEnum.ACH)
            {
                data.Append("&bank_routing_num=" + HttpUtility.UrlEncode(RoutingNumber));
                data.Append("&bank_acct_num=" + HttpUtility.UrlEncode(AccountNumber));
            }

            // Create a byte array of the data we want to send  
            byte[] byteData = UTF8Encoding.UTF8.GetBytes(data.ToString());

            // Set the content length in the request headers  
            request.ContentLength = byteData.Length;

            // Write data  
            using (Stream postStream = request.GetRequestStream())
            {
                postStream.Write(byteData, 0, byteData.Length);
            }

            // Get response  
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                // Get the url query string parameters  
                var queryString = System.Web.HttpUtility.ParseQueryString(response.ResponseUri.Query);
                var sessionId = queryString["inSessionID"];
                var errors = queryString["errors"];
                var key = queryString["error_messages[0][error_key]"];
                var code = queryString["error_messages[0][error_code]"];
                var field = queryString["error_messages[0][error_field]"];
            }  
        }

        #endregion
    }
}
