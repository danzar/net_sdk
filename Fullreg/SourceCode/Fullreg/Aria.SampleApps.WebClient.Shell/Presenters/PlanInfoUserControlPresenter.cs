// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlanInfoUserControlPresenter.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Plan Info User Control Presenter
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aria.SampleApps.Business.Services;
using Aria.SampleApps.Common.Dto;
using Aria.SampleApps.WebClient.Shell.Views;
using Microsoft.Practices.CompositeWeb;

namespace Aria.SampleApps.WebClient.Shell.Presenters
{
    public class PlanInfoUserControlPresenter : Presenter<IPlanInfoUserControlView>
    {
        /// <summary>
        /// Gets or sets the general services.
        /// </summary>
        /// <value>The general services.</value>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public IGeneralServices GeneralServices { get; set; }

        /// <summary>
        /// Loads the plans by currency cd.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void LoadPlansByCurrencyCd()
        {
            var list = GeneralServices.LoadPlansByCurrencyCd(View.Currency);

            // Sets the interval name accord to the interval No
            foreach (var planDto in list)
            {
                switch (planDto.Interval)
                {
                    case 1:
                        planDto.IntervalName = View.LabelsList["permonth"];
                        break;
                    case 3:
                        planDto.IntervalName = View.LabelsList["perquarter"];
                        break;
                    case 6:
                        planDto.IntervalName = View.LabelsList["per6months"];
                        break;
                    case 12:
                        planDto.IntervalName = View.LabelsList["peryear"];
                        break;
                    default:
                        planDto.IntervalName = View.LabelsList["per"] + " " + planDto.Interval.ToString() + " " + View.LabelsList["months"];
                        break;
                }
            }

            View.PlanDtoList = list;
        }

        /// <summary>
        /// Loads the plans by promo code.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void LoadPlansByPromoCode()
        {
            var list = GeneralServices.LoadPlansByPromoCode(View.PromoCode, View.Currency);

            // Sets the interval name accord to the interval No
            foreach (var planDto in list)
            {
                switch (planDto.Interval)
                {
                    case 1:
                        planDto.IntervalName = View.LabelsList["permonth"];
                        break;
                    case 3:
                        planDto.IntervalName = View.LabelsList["perquarter"];
                        break;
                    case 6:
                        planDto.IntervalName = View.LabelsList["per6months"];
                        break;
                    case 12:
                        planDto.IntervalName = View.LabelsList["peryear"];
                        break;
                    default:
                        planDto.IntervalName = View.LabelsList["per"] + " " + planDto.Interval.ToString() + " " + View.LabelsList["months"];
                        break;
                }
            }

            View.PlanDtoList = list;
        }

        /// <summary>
        /// Loads the supp plans.
        /// </summary>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public void LoadSuppPlans()
        {
            var list = GeneralServices.GetSuppPlansList(View.SelectedMasterPlanNo);

            // Sets the interval name accord to the interval No
            foreach (var planDto in list)
            {
                // the supp plan price is taken from plans list
                planDto.Price = View.PlanDtoList.Where(p => p.Id == planDto.Id).FirstOrDefault().Price;

                switch (planDto.Interval)
                {
                    case 1:
                        planDto.IntervalName = View.LabelsList["permonth"];
                        break;
                    case 3:
                        planDto.IntervalName = View.LabelsList["perquarter"];
                        break;
                    case 6:
                        planDto.IntervalName = View.LabelsList["per6months"];
                        break;
                    case 12:
                        planDto.IntervalName = View.LabelsList["peryear"];
                        break;
                    default:
                        planDto.IntervalName = View.LabelsList["per"] + " " + planDto.Interval.ToString() + " " + View.LabelsList["months"];
                        break;
                }
            }

            View.SuppPlanDtoList = list;
        }
    }
}
