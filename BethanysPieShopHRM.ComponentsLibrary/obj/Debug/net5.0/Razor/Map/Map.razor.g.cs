#pragma checksum "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23e6bf4ede6b1be9414cb92714990c7c50ee5126"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.ComponentsLibrary.Map
{
    #line hidden
    using System.Linq;
#nullable restore
#line 1 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor"
using BethanysPieShopHRM.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
    public partial class Map : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", 
#nullable restore
#line 9 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor"
          elementId

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(2, "style", "height: 100%; width: 100%;");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.ComponentsLibrary\Map\Map.razor"
       

    string elementId = $"map-{Guid.NewGuid().ToString("D")}";
    
    [Parameter] 
    public double Zoom { get; set; }

    [Parameter] 
    public List<Marker> Markers { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await JSRuntime.InvokeVoidAsync(
            "deliveryMap.showOrUpdate",
            elementId,
            Markers);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
