using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Component
{
    public class EmployeeRowBase : ComponentBase
    {
        [Parameter] // Allows a parent component to set the value of this property (passing props like React)
        public EmployeeModel Employee { get; set; }
    }
}
