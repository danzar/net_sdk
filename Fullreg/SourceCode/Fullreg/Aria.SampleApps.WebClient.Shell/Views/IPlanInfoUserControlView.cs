// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPlanInfoUserControlView.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Plan Info User Control View Interface
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aria.SampleApps.Common.Dto;

namespace Aria.SampleApps.WebClient.Shell.Views
{
    public interface IPlanInfoUserControlView
    {
        Dictionary<string, string> LabelsList { get; set; }
        List<PlanDto> PlanDtoList { get; set; }
        List<PlanDto> SuppPlanDtoList { get; set; }
        PlanDto SelectedMasterPlan { get; }
        long SelectedMasterPlanNo { get; set; }
        string Currency { get; set; }
        string PromoCode { get; set; }
    }
}
