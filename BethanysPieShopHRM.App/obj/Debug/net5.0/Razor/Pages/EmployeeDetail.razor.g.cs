#pragma checksum "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89eef8ceb98328a79d5793cc16f3b3c0f26b314e"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.App.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetail/{EmployeeId}")]
    public partial class EmployeeDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "employee-detail");
            __builder.OpenElement(2, "h1");
            __builder.AddAttribute(3, "class", "page-title");
            __builder.AddContent(4, "Details for ");
            __builder.AddContent(5, 
#nullable restore
#line 4 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                            Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, " ");
            __builder.AddContent(7, 
#nullable restore
#line 4 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-12 row");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-2");
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 8 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                            $"https://gillcleerenpluralsight.blob.core.windows.net/person/{Employee.EmployeeId}.jpg"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "img-responsive rounded-circle employee-detail-img");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "col-10 row");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-xs-12 col-sm-8");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "form-group row");
            __builder.AddMarkupContent(23, "<label class=\"col-sm-4 col-form-label\">Employee ID</label>\r\n                        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-sm-8");
            __builder.OpenElement(26, "label");
            __builder.AddAttribute(27, "type", "text");
            __builder.AddAttribute(28, "class", "form-control-plaintext");
            __builder.AddContent(29, 
#nullable restore
#line 15 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                               Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "form-group row");
            __builder.AddMarkupContent(33, "<label class=\"col-sm-4 col-form-label\">First name</label>\r\n                        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-sm-8");
            __builder.OpenElement(36, "label");
            __builder.AddAttribute(37, "type", "text");
            __builder.AddAttribute(38, "readonly");
            __builder.AddAttribute(39, "class", "form-control-plaintext");
            __builder.AddContent(40, 
#nullable restore
#line 21 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n                    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "form-group row");
            __builder.AddMarkupContent(44, "<label class=\"col-sm-4 col-form-label\">Last name</label>\r\n                        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-sm-8");
            __builder.OpenElement(47, "label");
            __builder.AddAttribute(48, "type", "text");
            __builder.AddAttribute(49, "readonly");
            __builder.AddAttribute(50, "class", "form-control-plaintext");
            __builder.AddContent(51, 
#nullable restore
#line 28 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n                    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-group row");
            __builder.AddMarkupContent(55, "<label class=\"col-sm-4 col-form-label\">Birthdate</label>\r\n                        ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "col-sm-8");
            __builder.OpenElement(58, "label");
            __builder.AddAttribute(59, "type", "text");
            __builder.AddAttribute(60, "readonly");
            __builder.AddAttribute(61, "class", "form-control-plaintext");
            __builder.AddContent(62, 
#nullable restore
#line 35 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.BirthDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n\r\n                    ");
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "form-group row");
            __builder.AddMarkupContent(66, "<label class=\"col-sm-4 col-form-label\">Email</label>\r\n                        ");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "col-sm-8");
            __builder.OpenElement(69, "label");
            __builder.AddAttribute(70, "type", "text");
            __builder.AddAttribute(71, "readonly");
            __builder.AddAttribute(72, "class", "form-control-plaintext");
            __builder.AddContent(73, 
#nullable restore
#line 42 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n\r\n                    ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "form-group row");
            __builder.AddMarkupContent(77, "<label class=\"col-sm-4 col-form-label\">Street</label>\r\n                        ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "col-sm-8");
            __builder.OpenElement(80, "label");
            __builder.AddAttribute(81, "type", "text");
            __builder.AddAttribute(82, "readonly");
            __builder.AddAttribute(83, "class", "form-control-plaintext");
            __builder.AddContent(84, 
#nullable restore
#line 49 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.Street

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\r\n                    ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "form-group row");
            __builder.AddMarkupContent(88, "<label class=\"col-sm-4 col-form-label\">Zip</label>\r\n                        ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "col-sm-8");
            __builder.OpenElement(91, "label");
            __builder.AddAttribute(92, "type", "text");
            __builder.AddAttribute(93, "readonly");
            __builder.AddAttribute(94, "class", "form-control-plaintext");
            __builder.AddContent(95, 
#nullable restore
#line 56 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.Zip

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n\r\n                    ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "form-group row");
            __builder.AddMarkupContent(99, "<label class=\"col-sm-4 col-form-label\">City</label>\r\n                        ");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "col-sm-8");
            __builder.OpenElement(102, "label");
            __builder.AddAttribute(103, "type", "text");
            __builder.AddAttribute(104, "readonly");
            __builder.AddAttribute(105, "class", "form-control-plaintext");
            __builder.AddContent(106, 
#nullable restore
#line 63 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.City

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n\r\n                    ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "form-group row");
            __builder.AddMarkupContent(110, "<label class=\"col-sm-4 col-form-label\">Phone number</label>\r\n                        ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "col-sm-8");
            __builder.OpenElement(113, "label");
            __builder.AddAttribute(114, "type", "text");
            __builder.AddAttribute(115, "readonly");
            __builder.AddAttribute(116, "class", "form-control-plaintext");
            __builder.AddContent(117, 
#nullable restore
#line 70 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.PhoneNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n\r\n                    ");
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "form-group row");
            __builder.AddMarkupContent(121, "<label class=\"col-sm-4 col-form-label\">Gender</label>\r\n                        ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "col-sm-8");
            __builder.OpenElement(124, "label");
            __builder.AddAttribute(125, "type", "text");
            __builder.AddAttribute(126, "readonly");
            __builder.AddAttribute(127, "class", "form-control-plaintext");
            __builder.AddContent(128, 
#nullable restore
#line 77 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n\r\n                    ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "form-group row");
            __builder.AddMarkupContent(132, "<label class=\"col-sm-4 col-form-label\">Smoker</label>\r\n                        ");
            __builder.OpenElement(133, "div");
            __builder.AddAttribute(134, "class", "col-sm-8");
#nullable restore
#line 85 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                             if (Employee.Smoker)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(135, "<label type=\"text\" readonly class=\"form-control-plaintext\">Yes</label>");
#nullable restore
#line 88 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(136, "<label type=\"text\" readonly class=\"form-control-plaintext\">No</label>");
#nullable restore
#line 92 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"

                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n\r\n                    ");
            __builder.OpenElement(138, "div");
            __builder.AddAttribute(139, "class", "form-group row");
            __builder.AddMarkupContent(140, "<label class=\"col-sm-4 col-form-label\">Joined us</label>\r\n                        ");
            __builder.OpenElement(141, "div");
            __builder.AddAttribute(142, "class", "col-sm-8");
            __builder.OpenElement(143, "label");
            __builder.AddAttribute(144, "type", "text");
            __builder.AddAttribute(145, "readonly");
            __builder.AddAttribute(146, "class", "form-control-plaintext");
            __builder.AddContent(147, 
#nullable restore
#line 100 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.JoinedDate?.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n\r\n                    ");
            __builder.OpenElement(149, "div");
            __builder.AddAttribute(150, "class", "form-group row");
            __builder.AddMarkupContent(151, "<label class=\"col-sm-4 col-form-label\">Left us</label>\r\n                        ");
            __builder.OpenElement(152, "div");
            __builder.AddAttribute(153, "class", "col-sm-8");
            __builder.OpenElement(154, "label");
            __builder.AddAttribute(155, "type", "text");
            __builder.AddAttribute(156, "readonly");
            __builder.AddAttribute(157, "class", "form-control-plaintext");
            __builder.AddContent(158, 
#nullable restore
#line 107 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.ExitDate?.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                ");
            __builder.OpenElement(160, "div");
            __builder.AddAttribute(161, "class", "col-xs-12 col-sm-4");
            __builder.OpenElement(162, "div");
            __builder.AddAttribute(163, "class", "track-order-map");
            __builder.OpenComponent<BethanysPieShopHRM.ComponentsLibrary.Map.Map>(164);
            __builder.AddAttribute(165, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 113 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                   10

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(166, "Markers", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BethanysPieShopHRM.ComponentsLibrary.Map.Marker>>(
#nullable restore
#line 113 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                MapMarkers

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
