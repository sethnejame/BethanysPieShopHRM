#pragma checksum "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5456520839664fbbeb726a4af0946602a9d68f5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Counter_razor), @"mvc.1.0.razor-page", @"/Pages/Counter.razor")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/counter")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5456520839664fbbeb726a4af0946602a9d68f5c", @"/Pages/Counter.razor")]
    public class Pages_Counter_razor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Counter</h1>\r\n\r\n<p>Current count: ");
#nullable restore
#line 5 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.Client\Pages\Counter.razor"
             Write(currentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<button class=\"btn btn-primary\" ");
#nullable restore
#line 7 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.Client\Pages\Counter.razor"
                           Write(onclick);

#line default
#line hidden
#nullable disable
            WriteLiteral("=\"IncrementCount\">Click me</button>\r\n\r\n");
#nullable restore
#line 9 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.Client\Pages\Counter.razor"
Write(code);

#line default
#line hidden
#nullable disable
            WriteLiteral(" {\r\n    private int currentCount = 0;\r\n\r\n    private void IncrementCount()\r\n    {\r\n        currentCount++;\r\n    }\r\n}\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Counter_razor> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Counter_razor> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Counter_razor>)PageContext?.ViewData;
        public Pages_Counter_razor Model => ViewData.Model;
    }
}
#pragma warning restore 1591
