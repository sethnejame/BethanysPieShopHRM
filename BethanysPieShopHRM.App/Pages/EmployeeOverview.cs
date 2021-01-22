using System;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.App.Component;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeOverview
    {
        public IEnumerable<Employee> Employees { get; set; }

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        protected AddEmployeeDialog AddEmployeeDialog { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetAllEmployees()).ToList();
   
        }

        protected void QuickAddEmployee()
        {
            AddEmployeeDialog.Show();
        }

        public async void AddEmployeeDialog_OnDialogClose()
        {
            Employees = (await EmployeeService.GetAllEmployees()).ToList();
            StateHasChanged();
        }
    }
}
