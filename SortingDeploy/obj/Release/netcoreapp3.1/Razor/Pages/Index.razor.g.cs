#pragma checksum "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2db15bb3165ee77e66f7fa032dd43982b5f5fe8e"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello world</h1>\r\n\r\n\r\n");
            __builder.OpenElement(1, "select");
            __builder.AddAttribute(2, "class", "form-control");
            __builder.AddAttribute(3, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
                                    sortingType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => sortingType = __value, sortingType));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "option");
            __builder.AddAttribute(7, "disabled", true);
            __builder.AddAttribute(8, "selected", true);
            __builder.AddAttribute(9, "hidden", true);
            __builder.AddContent(10, "Choice");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "option");
            __builder.AddContent(13, "Bubble Sort");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "option");
            __builder.AddContent(16, "Selection Sort");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "option");
            __builder.AddContent(19, "Insertion Sort");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n<p></p>\r\n");
            __builder.AddMarkupContent(22, "<p>Number of randoms:</p>\r\n");
            __builder.OpenElement(23, "input");
            __builder.AddAttribute(24, "type", "range");
            __builder.AddAttribute(25, "min", "1");
            __builder.AddAttribute(26, "max", "50");
            __builder.AddAttribute(27, "step", "1");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
                                                     numberOfRandoms

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => numberOfRandoms = __value, numberOfRandoms));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n");
            __builder.OpenElement(31, "p");
            __builder.AddContent(32, 
#nullable restore
#line 20 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
    printNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.AddMarkupContent(34, "<p>Range of randoms:</p>\r\n");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "range");
            __builder.AddAttribute(37, "min", "1");
            __builder.AddAttribute(38, "max", "100");
            __builder.AddAttribute(39, "step", "1");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
                                                      rangeOfRandoms

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rangeOfRandoms = __value, rangeOfRandoms));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
            __builder.OpenElement(43, "p");
            __builder.AddContent(44, 
#nullable restore
#line 23 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
    printRange

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "class", "btn btn-primary");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
                                          Randomize

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n");
            __builder.OpenElement(51, "p");
            __builder.AddContent(52, "Random number: ");
            __builder.AddContent(53, 
#nullable restore
#line 26 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
                   stro

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n");
            __builder.OpenElement(55, "p");
            __builder.AddContent(56, "Sorting: ");
            __builder.AddContent(57, 
#nullable restore
#line 27 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
             currentArray

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Zolly\source\repos\SortingDeploy\SortingDeploy\Pages\Index.razor"
       

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



    protected void Randomize()
    {

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
            srt.SelectionSort(array, arraySize);
        }
        else if (sortingType == "Insertion Sort")
        {
            srt.InsertionSort(array, arraySize);
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
        Debug.WriteLine("We are in the update");
        
        await Task.Delay(2);
        StateHasChanged();
        Debug.WriteLine(tempArray);
        tempArray = "";
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
