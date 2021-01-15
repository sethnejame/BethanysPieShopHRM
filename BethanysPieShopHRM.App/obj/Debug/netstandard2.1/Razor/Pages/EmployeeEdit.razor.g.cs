#pragma checksum "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "409f058e868c4f517adaf038c1bdb4eb27360690"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeedit")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeeedit/{EmployeeId}")]
    public partial class EmployeeEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "employee-edit");
            __builder.OpenElement(2, "h1");
            __builder.AddAttribute(3, "class", "page-title");
            __builder.AddContent(4, "Details for ");
            __builder.AddContent(5, 
#nullable restore
#line 5 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                        Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, " ");
            __builder.AddContent(7, 
#nullable restore
#line 5 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                                            Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                      Employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group row");
                __builder2.AddMarkupContent(14, "<label for=\"lastName\" class=\"col-sm-3\">Last name: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "id", "lastName");
                __builder2.AddAttribute(17, "class", "form-control col-sm-8");
                __builder2.AddAttribute(18, "placeholder", "Enter last name");
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                                                                 Employee.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.LastName = __value, Employee.LastName))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.LastName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n        ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group row");
                __builder2.AddMarkupContent(25, "<label for=\"firstName\" class=\"col-sm-3\">First name: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "id", "firstName");
                __builder2.AddAttribute(28, "class", "form-control col-sm-8");
                __builder2.AddAttribute(29, "placeholder", "Enter first name");
                __builder2.AddAttribute(30, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                                                                  Employee.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.FirstName = __value, Employee.FirstName))));
                __builder2.AddAttribute(32, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.FirstName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group row");
                __builder2.AddMarkupContent(36, "<label for=\"birthdate\" class=\"col-sm-3\">Birthdate: </label>\r\n            ");
                __Blazor.BethanysPieShopHRM.App.Pages.EmployeeEdit.TypeInference.CreateInputDate_0(__builder2, 37, 38, "birthdate", 39, "form-control col-sm-8", 40, "Enter birthdate", 41, 
#nullable restore
#line 17 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                                                                  Employee.BirthDate

#line default
#line hidden
#nullable disable
                , 42, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.BirthDate = __value, Employee.BirthDate)), 43, () => Employee.BirthDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group row");
                __builder2.AddMarkupContent(47, "<label for=\"email\" class=\"col-sm-3\">Email: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(48);
                __builder2.AddAttribute(49, "id", "email");
                __builder2.AddAttribute(50, "class", "form-control col-sm-8");
                __builder2.AddAttribute(51, "placeholder", "Enter email");
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                                                              Employee.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Email = __value, Employee.Email))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group row");
                __builder2.AddMarkupContent(58, "<label for=\"street\" class=\"col-sm-3\">Street: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(59);
                __builder2.AddAttribute(60, "id", "street");
                __builder2.AddAttribute(61, "class", "form-control col-sm-8");
                __builder2.AddAttribute(62, "placeholder", "Enter street");
                __builder2.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                                                               Employee.Street

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Street = __value, Employee.Street))));
                __builder2.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Street));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n        ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group row");
                __builder2.AddMarkupContent(69, "<label for=\"zip\" class=\"col-sm-3\">Zip Code: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(70);
                __builder2.AddAttribute(71, "id", "zip");
                __builder2.AddAttribute(72, "class", "form-control col-sm-8");
                __builder2.AddAttribute(73, "placeholder", "Enter zip code");
                __builder2.AddAttribute(74, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                                                            Employee.Zip

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Zip = __value, Employee.Zip))));
                __builder2.AddAttribute(76, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.Zip));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n        ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-group row");
                __builder2.AddMarkupContent(80, "<label for=\"city\" class=\"col-sm-3\">City: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(81);
                __builder2.AddAttribute(82, "id", "city");
                __builder2.AddAttribute(83, "class", "form-control col-sm-8");
                __builder2.AddAttribute(84, "placeholder", "Enter city");
                __builder2.AddAttribute(85, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                                                             Employee.City

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.City = __value, Employee.City))));
                __builder2.AddAttribute(87, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.City));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n        ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "form-group");
                __builder2.AddMarkupContent(91, "<label for=\"country\" class=\"col-sm-3\">Country: </label>\r\n            ");
                __Blazor.BethanysPieShopHRM.App.Pages.EmployeeEdit.TypeInference.CreateInputSelect_1(__builder2, 92, 93, "country", 94, "form-control col-sm-8", 95, 
#nullable restore
#line 37 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                                    CountryId

#line default
#line hidden
#nullable disable
                , 96, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => CountryId = __value, CountryId)), 97, () => CountryId, 98, (__builder3) => {
#nullable restore
#line 38 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                 foreach (var country in Countries)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(99, "option");
                    __builder3.AddAttribute(100, "value", 
#nullable restore
#line 40 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                    country.CountryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(101, 
#nullable restore
#line 40 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                                        country.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
#nullable restore
#line 41 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n        ");
                __builder2.OpenElement(103, "div");
                __builder2.AddAttribute(104, "class", "form-group row");
                __builder2.AddMarkupContent(105, "<label for=\"phonenumber\" class=\"col-sm-3\">Phone number: </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(106);
                __builder2.AddAttribute(107, "id", "phonenumber");
                __builder2.AddAttribute(108, "class", "form-control col-sm-8");
                __builder2.AddAttribute(109, "placeholder", "Enter phone number");
                __builder2.AddAttribute(110, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                                                                    Employee.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(111, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.PhoneNumber = __value, Employee.PhoneNumber))));
                __builder2.AddAttribute(112, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Employee.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n        ");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "form-group row");
                __builder2.AddMarkupContent(116, "<label for=\"longitude\" class=\"col-sm-3\">Longitude: </label>\r\n            ");
                __Blazor.BethanysPieShopHRM.App.Pages.EmployeeEdit.TypeInference.CreateInputNumber_2(__builder2, 117, 118, "longitude", 119, "form-control col-sm-8", 120, "Enter longitude", 121, 
#nullable restore
#line 50 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                                                                    Employee.Longitude

#line default
#line hidden
#nullable disable
                , 122, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Longitude = __value, Employee.Longitude)), 123, () => Employee.Longitude);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n        ");
                __builder2.OpenElement(125, "div");
                __builder2.AddAttribute(126, "class", "form-group row");
                __builder2.AddMarkupContent(127, "<label for=\"latitude\" class=\"col-sm-3\">Latitude: </label>\r\n            ");
                __Blazor.BethanysPieShopHRM.App.Pages.EmployeeEdit.TypeInference.CreateInputNumber_3(__builder2, 128, 129, "latitude", 130, "form-control col-sm-8", 131, "Enter latitude", 132, 
#nullable restore
#line 54 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                                                                   Employee.Latitude

#line default
#line hidden
#nullable disable
                , 133, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Latitude = __value, Employee.Latitude)), 134, () => Employee.Latitude);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(135, "\r\n        ");
                __builder2.OpenElement(136, "div");
                __builder2.AddAttribute(137, "class", "form-group row");
                __builder2.OpenElement(138, "label");
                __builder2.AddAttribute(139, "for", "smoker");
                __builder2.AddAttribute(140, "class", "offset-sm-3");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(141);
                __builder2.AddAttribute(142, "id", "smoker");
                __builder2.AddAttribute(143, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "D:\Coding\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeEdit.razor"
                                                         Employee.Smoker

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(144, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Employee.Smoker = __value, Employee.Smoker))));
                __builder2.AddAttribute(145, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => Employee.Smoker));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(146, "\r\n            &nbsp;Smoker\r\n            ");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.BethanysPieShopHRM.App.Pages.EmployeeEdit
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
