#pragma checksum "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6925a1e7b0ae5e588cc113daa0bc9a970d3097a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SortingDeploy.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using SortingDeploy;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using SortingDeploy.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using SortingDeploy.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using SortingDeploy.Pages.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.BarChart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.BarChart.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.Common.Properties;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.ChartJS.Common.Wrappers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
           

        SortingMethods srt = new SortingMethods();
        private bool b = false;
        private int arraySize = 10;
        private int[] array;
        private string stro = "";

        private string sortingType;
        private int numberOfRandoms;
        private int rangeOfRandoms;
        private int printNumber;
        private int printRange;
        private string currentArray;
        private string tempArray;
        private int check;
        private bool checkBool;
        protected bool IsDisabled { get; set; }

        private BarConfig _barChartConfig;
        private ChartJsBarChart _barChart;
        private BarDataset<DoubleWrapper> _barDataSet;

        private void Randomize()
        {
            if(sortingType == null)
            {
                sortingType = "Bubble Sort";
            }
            DisableCheck();
            check = 1;

            if (checkBool)
            {
                _barDataSet.RemoveRange(0, arraySize);
                _barChartConfig.Data.Labels.RemoveRange(0, arraySize);
            }
            checkBool = true;

            array = new int[numberOfRandoms];
            arraySize = numberOfRandoms;

            stro = "";
            srt.CreateRandomArray(arraySize, array, rangeOfRandoms);

            for (int i = 0; i < array.Length; i++)
            {
                stro = stro + " " + array[i];
            }

            if (sortingType == "Bubble Sort")
            {
                srt.BubbleSort(array, arraySize, this);
            }
            else if (sortingType == "Selection Sort")
            {
                srt.SelectionSort(array, arraySize, this);
            }
            else if (sortingType == "Insertion Sort")
            {
                srt.InsertionSort(array, arraySize, this);
            }

            printNumber = numberOfRandoms;
            printRange = rangeOfRandoms;

        }

        public async Task Update(int[] a)
        {
            array = a;

            for (int i = 0; i < array.Length; i++)
            {
                tempArray = tempArray + " " + array[i];
            }

            currentArray = tempArray;
            await Task.Delay(2);


            if (check == 1)
            {
                Debug.WriteLine("Before add range: " + check);
                _barChartConfig.Data.Labels.AddRange(Range());

                Debug.WriteLine("After add range: " + check);
            }

            check++;
            if (check > 2)
            {
                _barDataSet.RemoveRange(0, arraySize);

            }

            _barDataSet.AddRange(DoubleArray().Wrap());

            await _barChart.Update();
            StateHasChanged();

            Debug.WriteLine(tempArray);
            tempArray = "";

        }

        protected override void OnInitialized()
        {
            _barChartConfig = new BarConfig
            {
                Options = new BarOptions
                {
                    Title = new OptionsTitle
                    {
                        Display = true,
                        Text = "Simple Bar Chart"
                    },

                    Responsive = true,
                    Scales = new BarScales
                    {
                        YAxes = new List<CartesianAxis> {
                        new LinearCartesianAxis {
                            Ticks = new LinearCartesianTicks {
                                AutoSkip = false,
                                Min = 0 // Otherwise the lowest value in the dataset won't be visible
                            }
                        }
                    }
                    }
                }
            };

            _barChartConfig.Data.Labels.AddRange(Range());

            _barDataSet = new BarDataset<DoubleWrapper>
            {
                Label = "",
                BackgroundColor = "red",
                BorderWidth = 0,
                HoverBackgroundColor = ColorUtil.RandomColorString(),
                HoverBorderColor = ColorUtil.RandomColorString(),
                HoverBorderWidth = 1,
                BorderColor = "#ffffff"
            };

            _barDataSet.AddRange(DoubleArray().Wrap());
            _barChartConfig.Data.Datasets.Add(_barDataSet);

        }


        private double[] DoubleArray()
        {
            List<double> temp = new List<double>();
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    temp.Add(array[i]);
                }
                double[] d = temp.ToArray();
                return d;
            }
            if (array == null)
            {
                double[] d = temp.ToArray();
                return d;
            }
            return null;
        }

        private string[] Range()
        {
            List<string> temp = new List<string>();
            if (array == null)
            {

                string[] str = temp.ToArray();
                return str;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    temp.Add(i + "");
                }
                string[] str = temp.ToArray();
                return str;
            }

        }

        public void DisableCheck()
        {

            if (IsDisabled)
            {
                IsDisabled = false;
            }
            else
            {
                IsDisabled = true;
            }
            StateHasChanged();
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
