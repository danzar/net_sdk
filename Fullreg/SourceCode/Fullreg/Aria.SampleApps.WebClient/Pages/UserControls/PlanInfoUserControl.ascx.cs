// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlanInfoUserControl.ascx.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Plan Info User Control
// </summary>
// --------------------------------------------------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using Aria.SampleApps.Common.Dto;
using Aria.SampleApps.Common.Web;
using Aria.SampleApps.WebClient.Shell.Presenters;
using Aria.SampleApps.WebClient.Shell.Views;

namespace ARIA.Pages.UserControls
{
    public partial class PlanInfoUserControl :
        MvpBaseUserControl<PlanInfoUserControlPresenter, IPlanInfoUserControlView>, IPlanInfoUserControlView, ICallbackEventHandler
    {

        #region Properties

        //string returnValue;

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
        /// Gets or sets the selected master plan.
        /// </summary>
        /// <value>The selected master plan.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public PlanDto SelectedMasterPlan
        {
            get
            {
                if (SelectedMasterPlanNo == 0)
                {
                    return null;
                }

                var selectedMasterPlan = (from plan in PlanDtoList
                                          where plan.Id == SelectedMasterPlanNo
                                          select plan).FirstOrDefault();

                long units = 0;

                foreach (ListViewItem item in this.plansListView.Items)
                {
                    var planNoHiddenField = item.FindControl("planNoHiddenField") as Literal;

                    if (planNoHiddenField.Text == SelectedMasterPlanNo.ToString())
                    {
                        var planUnitsTexBox = item.FindControl("planUnitsTexBox") as HtmlInputText;
                        units = !string.IsNullOrEmpty(planUnitsTexBox.Value) ? 
                            long.Parse(planUnitsTexBox.Value) : 0;
                    }
                }

                selectedMasterPlan.Units = units;
                return selectedMasterPlan;
            }
        }

        /// <summary>
        /// Gets or sets the selected master plan no.
        /// </summary>
        /// <value>The selected master plan no.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public long SelectedMasterPlanNo
        {
            get
            {
                if (ViewState["SelectedMasterPlanNo"] != null)
                {
                    return (long)ViewState["SelectedMasterPlanNo"];
                }

                return 0;
            }
            set
            {
                ViewState["SelectedMasterPlanNo"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the plan dto list.
        /// </summary>
        /// <value>The plan dto list.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public List<PlanDto> PlanDtoList
        {
            get
            {
                if (Session["PlanDtoList"] != null)
                {
                    return Session["PlanDtoList"] as List<PlanDto>;
                }

                return new List<PlanDto>();
            }
            set
            {
                Session["PlanDtoList"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the supp plan dto list.
        /// </summary>
        /// <value>The supp plan dto list.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public List<PlanDto> SuppPlanDtoList
        {
            get
            {
                if (ViewState["SuppPlanDtoList"] != null)
                {
                    return ViewState["SuppPlanDtoList"] as List<PlanDto>;
                }

                return new List<PlanDto>();
            }
            set
            {
                ViewState["SuppPlanDtoList"] = value;
            }
        }

        /// <summary>
        /// Sets the currency list.
        /// </summary>
        /// <value>The currency list.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public Dictionary<string, string> CurrencyList
        {
            set
            {
                selectcurrencyLabelDropDownList.DataSource = value;
                selectcurrencyLabelDropDownList.DataValueField = "Key";
                selectcurrencyLabelDropDownList.DataTextField = "Value";
                selectcurrencyLabelDropDownList.DataBind();
            }
        }

        /// <summary>
        /// Gets or sets the currency.
        /// </summary>
        /// <value>The currency.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public string Currency
        {
            get
            {
                return selectcurrencyLabelDropDownList.SelectedValue;
            }
            set
            {
                selectcurrencyLabelDropDownList.SelectedValue = value;
            }
        }

        /// <summary>
        /// Gets or sets the coupon code.
        /// </summary>
        /// <value>The coupon code.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public string CouponCode
        {
            get
            {
                return ifyouhavecuponcodeTextBox.Text;
            }
            set
            {
                ifyouhavecuponcodeTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets the promo code.
        /// </summary>
        /// <value>The promo code.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public string PromoCode
        {
            get
            {
                return ifyouhavepromocodeLabelTexBox.Text;
            }
            set
            {
                ifyouhavepromocodeLabelTexBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets the edit master plan.
        /// </summary>
        /// <value>The edit master plan.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public PlanDto EditMasterPlan
        {
            get
            {
                if (ViewState["EditMasterPlan"] != null)
                {
                    return ViewState["EditMasterPlan"] as PlanDto;
                }

                return null;
            }
            set
            {
                ViewState["EditMasterPlan"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the edit supp plans list.
        /// </summary>
        /// <value>The edit supp plans list.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public List<PlanDto> EditSuppPlansList
        {
            get
            {
                if (ViewState["EditSuppPlansList"] != null)
                {
                    return ViewState["EditSuppPlansList"] as List<PlanDto>;
                }

                return new List<PlanDto>();
            }
            set
            {
                ViewState["EditSuppPlansList"] = value;
            }
        }

        /// <summary>
        /// Gets the supp plans selected list.
        /// </summary>
        /// <value>The supp plans selected list.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public List<PlanDto> SuppPlansSelectedList
        {
            get
            {
                var retList = new List<PlanDto>();

                foreach (GridViewRow row in suppPlansGridView.Rows)
                {
                    TextBox unitsTexBox = (TextBox)row.FindControl("unitsTexBox");
                    HiddenField suppPlanIdHiddenField = (HiddenField)row.FindControl("suppPlanIdHiddenField");
                    Label descLabel = (Label)row.FindControl("descLabel");
                    Label planPriceLabel = (Label)row.FindControl("planPriceLabel");

                    if (!string.IsNullOrEmpty(unitsTexBox.Text))
                    {
                        var suppPlan =
                            new PlanDto
                                {
                                    Id = long.Parse(suppPlanIdHiddenField.Value), 
                                    Units = long.Parse(unitsTexBox.Text),
                                    Price = double.Parse(planPriceLabel.Text),
                                    Description = descLabel.Text
                                };

                        retList.Add(suppPlan);
                    }
                }

                return retList;
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
                RegisterRadioButtonCallBack();

                if(LabelsList != null)
                {
                    LoadLabelsText();
                }
            }
        }

        /// <summary>
        /// Loads the plans data.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void LoadPlansData(object sender, EventArgs e)
        {
            presenter.LoadPlansByCurrencyCd();

            if (EditMasterPlan != null)
            {
                LoadEditPlansAndSuppPlans();
            }
            else
            {
                plansListView.DataSource = PlanDtoList;
                wrapperExternal.Visible = false;
                plansListView.DataBind();
            }
        }

        /// <summary>
        /// Registers the script, This script is for the asynchronous loading of plans
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void RegisterScript(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "callLoadPlans", "<script language='javascript'>TimerLoadPlans();</script>");
        }

        /// <summary>
        /// Loads the edit plans and supp plans, when is an edition and the plant data was selected before
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private void LoadEditPlansAndSuppPlans()
        {
            PlanDtoList.Where(p => p.Id == EditMasterPlan.Id).FirstOrDefault().MasterPlan = true;
            PlanDtoList.Where(p => p.Id == EditMasterPlan.Id).FirstOrDefault().Units = EditMasterPlan.Units;
            SelectedMasterPlanNo = EditMasterPlan.Id;
            plansValidator.Text = SelectedMasterPlanNo.ToString();
            plansListView.DataSource = PlanDtoList;
            wrapperExternal.Visible = false;
            plansListView.DataBind();
            presenter.LoadSuppPlans();

            if (EditSuppPlansList != null)
            {
                var tempSuppPlanDtoList = SuppPlanDtoList.ToList();

                foreach (var suppPlan in tempSuppPlanDtoList)
                {
                    var supp = EditSuppPlansList.Where(p => p.Id == suppPlan.Id).FirstOrDefault();

                    if (supp != null)
                    {
                        suppPlan.Units = supp.Units;
                    }
                }

                SuppPlanDtoList = tempSuppPlanDtoList;
            }

            suppPlansGridView.DataSource = SuppPlanDtoList;
            suppPlansGridView.DataBind();
            suppPlansUpdatePanel.Update();


        }

        /// <summary>
        /// Loads the labels text.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private void LoadLabelsText()
        {
            selectplaninformationLabel.Text = LabelsList["selectplaninformation"];
            selectcurrencyLabel.Text = LabelsList["selectcurrency"];
            ifyouhavecuponcodeLabel.Text = LabelsList["ifyouhavecoupon"];
            ifyouhavepromocodeLabel.Text = LabelsList["ifyouhavepromocode"];
            suppPlansGridView.EmptyDataText  = LabelsList["nosuppplansavailable"];
            plansRequiredFieldValidator.Text = LabelsList["chooseaplan"];
            loadingpleasewaitLabel.Text = LabelsList["loadingpleasewait"];
            loadingpleasewaitLabel2.Text = LabelsList["loadingpleasewait"];
            loadingpleasewaitLabel3.Text = LabelsList["loadingpleasewait"];
            choosesupplementalplanLabel.Text = LabelsList["choosesupplementalplan"];
        }

        /// <summary>
        /// Builds the radio button, This is for decrease the size of the html, 
        /// as they may be many plans and using asp is heavier 
        /// </summary>
        /// <param name="check">if set to <c>true</c> [check].</param>
        /// <param name="id">The id.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public string BuildRadioButton(bool check, long id)
        {
            var ret = "<input id='planNoRadioButton' name='planNoRadioButton[]' type='radio' style='z-index:0' " +
                "onclick=\"javascript:LoadSuppPlansAndPlanServices('plans|" + id + "');\" ";
   
            return ret + (check ? "checked />" : "/>");
        }

        /// <summary>
        /// Registers the radio button call back.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        private void RegisterRadioButtonCallBack()
        {
            String callBack = Page.ClientScript.GetCallbackEventReference(this, "arg", "CallbackOnSucceeded", "context", "CallbackOnFailed", true);
            String clientFunction = "function CallServer(arg, context){ " + callBack + "; }";
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Call To Server", clientFunction, true);
        }

        /// <summary>
        /// Returns the results of a callback event that targets a control.
        /// </summary>
        /// <returns>The result of the callback.</returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        string ICallbackEventHandler.GetCallbackResult()
        {
            return string.Empty;
        }

        /// <summary>
        /// Processes a callback event that targets a control.
        /// </summary>
        /// <param name="eventArgument">A string that represents an event argument to pass to the event handler.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        void ICallbackEventHandler.RaiseCallbackEvent(string eventArgument)
        {
            Session["eventArgument"] = eventArgument;
        }

        /// <summary>
        /// Loads the supp plans and services.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void LoadSuppPlansAndServices(object sender, EventArgs e)
        {
            if (Session["eventArgument"] != null)
            {
                var eventArgument = Session["eventArgument"].ToString();
                Session["eventArgument"] = null;
                string[] parms = eventArgument.Split(new char[] { '|', ',', ';' });

                // When the javascript "functionLoadSuppPlansAndPlanServices" is used to load the plans and serivces 
                // a parameter indicates if is for plans or services
                switch (parms[0])
                {
                    case "plans":

                        SelectedMasterPlanNo = long.Parse(parms[1]);
                        plansValidator.Text = SelectedMasterPlanNo.ToString();
                        presenter.LoadSuppPlans();
                        suppPlansGridView.DataSource = SuppPlanDtoList;
                        suppPlansGridView.DataBind();
                        suppPlansUpdatePanel.Update();
                        break;

                    case "services":

                        var planId = long.Parse(parms[1]);

                        var plan = (from planList in PlanDtoList
                                    where planList.Id == planId
                                    select planList).FirstOrDefault();

                        foreach (var planDto in plan.ServiceList)
                        {
                            planDto.IntervalName = plan.IntervalName;
                        }

                        break;
                }
            }
        }

        /// <summary>
        /// Supps the plan price detail link button click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void SuppPlanPriceDetailLinkButtonClick(object sender, EventArgs e)
        {
            LinkButton priceDetailLinkButton = sender as LinkButton;
            GridViewRow subPlansGridViewRow = priceDetailLinkButton.Parent.Parent as GridViewRow;
            HiddenField suppPlanIdHiddenField = subPlansGridViewRow.Cells[0].FindControl("suppPlanIdHiddenField") as HiddenField;
            var planId = long.Parse(suppPlanIdHiddenField.Value);

            var plan = (from planList in PlanDtoList
                        where planList.Id == planId
                        select planList).FirstOrDefault();

            foreach (var planDto in plan.ServiceList)
            {
                planDto.IntervalName = plan.IntervalName;
            }
        }

        /// <summary>
        /// Planses the list view on data bound.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void PlansListViewOnDataBound(object sender, EventArgs e)
        {
            var link = LabelsList["planpricing_breakdownlink"];
            var units = LabelsList["masterplanunitslabel"];

            foreach (ListViewItem item in this.plansListView.Items)
            {
                //var priceDetailLinkButton = item.FindControl("planPricingDetailsLinkButton") as LinkButton;
                var priceDetailLinkButton = item.FindControl("planPricingDetailsLabel") as Literal;
                var unitsLabel = item.FindControl("unitsLabel") as Literal;
                priceDetailLinkButton.Text = link;
                unitsLabel.Text = units;
            }
        }

        /// <summary>
        /// Supps the plans grid view on row data bound.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void SuppPlansGridViewOnRowDataBound(object sender, EventArgs e)
        {
            foreach (GridViewRow row in this.suppPlansGridView.Rows)
            {
                var priceDetailLinkButton = row.FindControl("priceDetailLinkButton") as Literal;
                var unitsLabel = row.FindControl("unitsLabel") as Label;
                priceDetailLinkButton.Text = LabelsList["planpricing_breakdownlink"];
                unitsLabel.Text = LabelsList["howmany"];
            }
        }

        /// <summary>
        /// Loads the plans by currency cd.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void LoadPlansByCurrencyCd(object sender, EventArgs e)
        {
            presenter.LoadPlansByCurrencyCd();
            plansListView.DataSource = PlanDtoList;
            plansListView.DataBind();
            suppPlansGridView.DataSource = new List<PlanDto>();
            suppPlansGridView.DataBind();
        }

        /// <summary>
        /// Loads the plans by promo code.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void LoadPlansByPromoCode(object sender, EventArgs e)
        {
            if (PromoCode != string.Empty)
            {
                presenter.LoadPlansByPromoCode();
                plansListView.DataSource = PlanDtoList;
                plansListView.DataBind();
                suppPlansGridView.DataSource = new List<PlanDto>();
                suppPlansGridView.DataBind();
            }
        }

        #endregion
    }
}