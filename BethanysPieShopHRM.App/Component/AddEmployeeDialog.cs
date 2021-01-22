﻿using System;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;
using System.Collections.Generic;
using BethanysPieShopHRM.App.Services;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Component
{
    public partial class AddEmployeeDialog
    {
        public Employee Employee { get; set; }
        = new Employee { CountryId = 1, JobCategoryId = 1, BirthDate = DateTime.UtcNow, JoinedDate = DateTime.UtcNow };

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public bool ShowDialog { get; set; }

        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }

        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }

        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }

        private void ResetDialog()
        {
            Employee = new Employee { CountryId = 1, JobCategoryId = 1, BirthDate = DateTime.UtcNow, JoinedDate = DateTime.UtcNow };
        }

        protected async Task HandleValidSubmit()
        {
            await EmployeeService.AddEmployee(Employee);
            ShowDialog = false;

            await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }

    }
}
