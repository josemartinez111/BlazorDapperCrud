#pragma checksum "/Users/josemartinez/Documents/Dotnet/BlazerDapperCrud/BlazerDapperCrud/Pages/AddVideoPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9693d56a75b70f5504e063d79250d14879e0c273"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
