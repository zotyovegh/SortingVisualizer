using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChartJs.Blazor.ChartJS.BarChart;
using ChartJs.Blazor.ChartJS.Common.Properties;

namespace SortingDeploy.Data
{
    public class BarOptionsSub : BarOptions
    {
        /// <summary>
        /// General animation time
        /// </summary>
        public Animation Animation { get; set; }
    }
}
