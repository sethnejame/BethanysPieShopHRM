#pragma checksum "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\BenefitSelector.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e722abeed2139b2b56a7f768dbd1c2371ea762bf"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.App.Component
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
    public partial class BenefitSelector : BenefitSelectorBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\BenefitSelector.razor"
 if (Benefits == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 6 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\BenefitSelector.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-8");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table table-sm");
            __builder.AddMarkupContent(7, "<tr><th></th>\r\n                    <th class=\"w-auto\">Benefit</th>\r\n                    <th class=\"w-25\">Start Date</th>\r\n                    <th class=\"w-25\">End Date</th></tr>");
#nullable restore
#line 19 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\BenefitSelector.razor"
                 foreach (var benefit in Benefits)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BethanysPieShopHRM.App.Component.BenefitRow>(8);
            __builder.AddAttribute(9, "Benefit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BethanysPieShopHRM.Shared.BenefitModel>(
#nullable restore
#line 21 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\BenefitSelector.razor"
                                         benefit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnPremiumToggle", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 21 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\BenefitSelector.razor"
                                                                   () => CheckBoxChanged()

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 22 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\BenefitSelector.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-md-4 mt-1");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-primary");
            __builder.AddAttribute(16, "disabled", 
#nullable restore
#line 26 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\BenefitSelector.razor"
                                                       SaveButtonDisabled

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\BenefitSelector.razor"
                              SaveClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(18, "\r\n                Save\r\n            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\BenefitSelector.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
