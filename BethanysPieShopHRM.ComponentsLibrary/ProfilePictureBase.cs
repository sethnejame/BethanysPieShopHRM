using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.ComponentsLibrary
{
    public class ProfilePictureBase : ComponentBase
    {
        protected string CssClass { get; set;  } = "circle";

        [Parameter]
       public RenderFragment ChildContent { get; set; } // Name of the property matters, must be called ChildContent
    }
}
