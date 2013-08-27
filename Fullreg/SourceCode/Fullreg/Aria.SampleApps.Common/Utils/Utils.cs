// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utils.cs" company="ARIA">
//    Copyright (c) Aria 2011. All rights reserved. 
// </copyright>
// <author>Hector Fabio Gómez Usuga</author>
// <summary>
//  Utils
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Aria.SampleApps.Common.Configuration;

namespace Aria.SampleApps.Common.Utils
{
    public class Utils
    {
        /// <summary>
        /// Gets the currency symbol by iso currency symbol.
        /// </summary>
        /// <param name="isoCurrencySymbol">The iso currency symbol.</param>
        /// <returns></returns>
        /// <author>Hector Fabio Gómez Usuga.</author>
        public static string GetCurrencySymbolByIsoCurrencySymbol(string isoCurrencySymbol)
        {
            var cultures = CultureInfo.GetCultures(CultureTypes.InstalledWin32Cultures);
            var regionList = new List<RegionInfo>();

            foreach (var culture in cultures)
            {
                try
                {
                    var region = new RegionInfo(culture.LCID);
                    regionList.Add(region);
                }
                catch
                {
                    // Avoid the cultures that aren't available in region info
                }
            }

            var regionInfo = regionList.Where(r => r.ISOCurrencySymbol == isoCurrencySymbol.ToUpper());

            return regionInfo.Any() ? regionInfo.FirstOrDefault().CurrencySymbol : string.Empty;
        }
    }
}
