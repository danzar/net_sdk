// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Receipt.aspx.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Receipt Page
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
    public partial class Receipt : MvpBasePage<ReceiptPresenter, IReceiptView>, IReceiptView
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

        /// <summary>
        /// Gets or sets the account complete dto.
        /// </summary>
        /// <value>The account complete dto.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public AccountCompleteDto AccountCompleteDto
        {
            set
            {
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
                    presenter.ValidateSession();

                    if (!ValidateSessionDto.ValidSession)
                    {
                        MoveBackward(ARIASDKPages.CreateAccount);
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
            receiptLabel.Text = LabelsList["receipt"];
            printthispageLabel.Text = LabelsList["printthispage"];
            congratulationsLabel.Text = LabelsList["congratulations"];
            successfulsignupLabel.Text = LabelsList["successfulsignup"];
            successfulsignupreceiveemailLabel.Text = LabelsList["successfulsignupreceiveemail"];
            yourserviceLabel.Text = LabelsList["yourservice"];

            //PlanInfo
            invoicemasterplanLabel.Text = LabelsList["invoicemasterplan"];
            invoicesupplementalplansLabel.Text = LabelsList["invoicesupplementalplans"];

            //SummaryPlanInfo
            invoiceblurbLabel.Text = LabelsList["invoiceblurb"];
            invoicemasterplanLabel2.Text = LabelsList["invoicemasterplan"];
            invoicedescriptionLabel.Text = LabelsList["invoicedescription"];
            invoiceunitsLabel.Text = LabelsList["invoiceunits"];
            invoicerateperunitLabel.Text = LabelsList["invoicerateperunit"];
            invoiceamountLabel.Text = LabelsList["invoiceamount"];
            invoicetotalLabel.Text = LabelsList["invoicetotal"];
        }

        #endregion
    }
}