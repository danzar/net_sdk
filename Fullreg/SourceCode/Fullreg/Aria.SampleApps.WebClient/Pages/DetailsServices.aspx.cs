// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DetailsServices.aspx.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Details Services
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aria.SampleApps.Common.Dto;

namespace ARIA.Pages
{
    public partial class DetailsServices : System.Web.UI.Page
    {
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
        /// Gets the labels list.
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
        }

        /// <summary>
        /// Handles the Load event of the Page control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        /// <author>Hector Fabio Gómez Usuga.</author>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (LabelsList != null)
            {
                planpricing_includedservicesLabel.Text = LabelsList["planpricing_includedservices"];
            }

            int planId = Request.QueryString["planId"] != null ? Convert.ToInt32(Request.QueryString["planId"]) : -1;
            var plan = (from planList in PlanDtoList
                        where planList.Id == planId
                        select planList).FirstOrDefault();

            if (plan != null)
            {
                foreach (var planDto in plan.ServiceList)
                {
                    planDto.IntervalName = plan.IntervalName;
                }

                planServicesListView.DataSource = plan.ServiceList;
                planServicesListView.DataBind();
            }
            else
            {
                planServicesListView.DataSource = new List<PlanDto>();
                planServicesListView.DataBind();
            }
        }
    }
}