#pragma checksum "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10c834502e4bf9097fd1b49d425787bcf649bbf5"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.App.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App.Component;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-light");
            __builder.AddAttribute(2, "id", "sidebar-wrapper");
            __builder.AddAttribute(3, "b-thcm2l9sr1");
            __builder.AddMarkupContent(4, "<div class=\"sidebar-logo\" b-thcm2l9sr1><img class=\"img-responsive\" id=\"logo\" src=\"images/bethanylogo.png\" b-thcm2l9sr1></div>\r\n    ");
            __builder.AddMarkupContent(5, @"<div class=""profile"" b-thcm2l9sr1><div class=""profile-bg"" b-thcm2l9sr1><img class=""img-responsive"" src=""images/profilePicture.jpg"" b-thcm2l9sr1></div>
        <div class=""profile-picture"" b-thcm2l9sr1><img class=""img-responsive circle account-photo"" src=""images/profilePicture.jpg"" b-thcm2l9sr1></div></div>
    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "menu list-group list-group-flush");
            __builder.AddAttribute(8, "b-thcm2l9sr1");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(9);
            __builder.AddAttribute(10, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(11, "href", "/");
            __builder.AddAttribute(12, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 14 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Shared\NavMenu.razor"
                                                                                         NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "<span class=\"oi oi-home\" aria-hidden=\"true\" b-thcm2l9sr1></span> Home\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(16);
            __builder.AddAttribute(17, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(18, "href", "/employeeoverview");
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(20, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-thcm2l9sr1></span> Employees\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(22);
            __builder.AddAttribute(23, "class", "list-group-item list-group-item-action bg-light");
            __builder.AddAttribute(24, "href", "/employeeedit");
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "<span class=\"oi oi-list-rich\" aria-hidden=\"true\" b-thcm2l9sr1></span> Add new employee\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
