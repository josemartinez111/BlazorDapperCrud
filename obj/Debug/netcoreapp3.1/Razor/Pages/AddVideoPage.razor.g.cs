#pragma checksum "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/Pages/AddVideoPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9693d56a75b70f5504e063d79250d14879e0c273"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazerDapperCrud.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/_Imports.razor"
using BlazerDapperCrud;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/_Imports.razor"
using BlazerDapperCrud.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/Pages/AddVideoPage.razor"
using BlazerDapperCrud.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addvideo")]
    public partial class AddVideoPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Add A Video</h1>\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/Pages/AddVideoPage.razor"
                  video

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/Pages/AddVideoPage.razor"
                                           InsertVideo

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\n    ");
                __builder2.OpenElement(6, "table");
                __builder2.AddMarkupContent(7, "\n        ");
                __builder2.OpenElement(8, "tr");
                __builder2.AddMarkupContent(9, "\n            ");
                __builder2.AddMarkupContent(10, "<td>Video Title:</td>\n            ");
                __builder2.OpenElement(11, "td");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "required", true);
                __builder2.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/Pages/AddVideoPage.razor"
                                          video.Title

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => video.Title = __value, video.Title));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(17, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n        ");
                __builder2.OpenElement(19, "tr");
                __builder2.AddMarkupContent(20, "\n            ");
                __builder2.AddMarkupContent(21, "<td>Date Published:</td>\n            ");
                __builder2.OpenElement(22, "td");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "type", "date");
                __builder2.AddAttribute(25, "required", true);
                __builder2.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/Pages/AddVideoPage.razor"
                                          video.DatePublished

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => video.DatePublished = __value, video.DatePublished, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\n        ");
                __builder2.OpenElement(30, "tr");
                __builder2.AddMarkupContent(31, "\n            ");
                __builder2.AddMarkupContent(32, "<td>Is Active:</td>\n            ");
                __builder2.OpenElement(33, "td");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "type", "checkbox");
                __builder2.AddAttribute(36, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/Pages/AddVideoPage.razor"
                                              video.IsActive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => video.IsActive = __value, video.IsActive));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\n        ");
                __builder2.OpenElement(40, "tr");
                __builder2.AddMarkupContent(41, "\n            ");
                __builder2.OpenElement(42, "td");
                __builder2.AddAttribute(43, "colspan", "2");
                __builder2.AddAttribute(44, "style", "text-align: center;");
                __builder2.AddMarkupContent(45, "\n                <input type=\"submit\" value=\"Add\">\n                ");
                __builder2.OpenElement(46, "input");
                __builder2.AddAttribute(47, "type", "button");
                __builder2.AddAttribute(48, "value", "Cancel");
                __builder2.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/Pages/AddVideoPage.razor"
                                                               Cancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n        \n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/Pages/AddVideoPage.razor"
       
    ///∆: - ©Global-PROPERTIES
    //∆..............................
    readonly VideoModel video = new VideoModel();
    //∆..............................


    protected async Task InsertVideo() {
        await VideoService.InsertVideo(video);
        NavigationManager.NavigateTo("/");
    }

    // ∆ If they cancel they will navigate to the Home page
    void Cancel() => NavigationManager.NavigateTo("/");


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IVideoService VideoService { get; set; }
    }
}
#pragma warning restore 1591