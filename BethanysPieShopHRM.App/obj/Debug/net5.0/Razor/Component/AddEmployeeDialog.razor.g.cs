#pragma checksum "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\AddEmployeeDialog.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09551c88c49bb1147dcfd1ca5ba357068e3671e2"
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
    public partial class AddEmployeeDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\AddEmployeeDialog.razor"
 if (ShowDialog)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show d-block");
            __builder.AddAttribute(2, "id", "exampleModal");
            __builder.AddAttribute(3, "tabindex", "-1");
            __builder.AddAttribute(4, "role", "dialog");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-dialog");
            __builder.AddAttribute(7, "role", "document");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.AddMarkupContent(12, "<h5 class=\"modal-title\" id=\"titleLabel\">Employee Quick Add</h5>\r\n                    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "close");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\AddEmployeeDialog.razor"
                                                                   Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "data-dismiss", "modal");
            __builder.AddAttribute(18, "aria-label", "Close");
            __builder.AddMarkupContent(19, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "modal-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(23);
            __builder.AddAttribute(24, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\AddEmployeeDialog.razor"
                                      Employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\AddEmployeeDialog.razor"
                                                                HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(27);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(29);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n\r\n                        ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label for=\"lastName\">Last name: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "id", "lastName");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "placeholder", "Enter last name");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\AddEmployeeDialog.razor"
                                                                                        Employee.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.LastName = __value, Employee.LastName))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n                            ");
                __Blazor.BethanysPieShopHRM.App.Component.AddEmployeeDialog.TypeInference.CreateValidationMessage_0(__builder2, 42, 43, 
#nullable restore
#line 22 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\AddEmployeeDialog.razor"
                                                      () => Employee.LastName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n\r\n                        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "<label for=\"firstName\">First name: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "id", "firstName");
                __builder2.AddAttribute(50, "class", "form-control");
                __builder2.AddAttribute(51, "placeholder", "Enter first name");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 27 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\AddEmployeeDialog.razor"
                                                                                         Employee.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.FirstName = __value, Employee.FirstName))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n                            ");
                __Blazor.BethanysPieShopHRM.App.Component.AddEmployeeDialog.TypeInference.CreateValidationMessage_1(__builder2, 56, 57, 
#nullable restore
#line 28 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\AddEmployeeDialog.razor"
                                                      () => Employee.FirstName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n\r\n                        ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group");
                __builder2.AddMarkupContent(61, "<label for=\"email\">Email: </label>\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(62);
                __builder2.AddAttribute(63, "id", "email");
                __builder2.AddAttribute(64, "class", "form-control");
                __builder2.AddAttribute(65, "placeholder", "Enter email");
                __builder2.AddAttribute(66, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\AddEmployeeDialog.razor"
                                                                                     Employee.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Email = __value, Employee.Email))));
                __builder2.AddAttribute(68, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n                            ");
                __Blazor.BethanysPieShopHRM.App.Component.AddEmployeeDialog.TypeInference.CreateValidationMessage_2(__builder2, 70, 71, 
#nullable restore
#line 34 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\AddEmployeeDialog.razor"
                                                      () => Employee.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                        ");
                __builder2.AddMarkupContent(73, "<button type=\"submit\" class=\"btn btn-primary\">Save employee</button>\r\n                        ");
                __builder2.OpenElement(74, "a");
                __builder2.AddAttribute(75, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\AddEmployeeDialog.razor"
                                                                      Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(77, "Close");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Component\AddEmployeeDialog.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BethanysPieShopHRM.App.Component.AddEmployeeDialog
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
