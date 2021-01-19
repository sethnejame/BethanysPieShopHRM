using System;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;
using System.Collections.Generic;
using BethanysPieShopHRM.App.Services;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeEdit
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Inject]
        public ICountryService CountryService { get; set; }

        [Inject]
        public IJobCategoryService JobCategoryService { get; set; }

        [Parameter]
        public string EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();

        public List<Country> Countries { get; set; } = new List<Country>();

        public List<JobCategory> JobCategories { get; set; } = new List<JobCategory>();

        public string JobCategoryId = string.Empty;
        protected string CountryId = string.Empty;

        // used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;


        protected async override Task OnInitializedAsync()
        {
            Countries = (await CountryService.GetAllCountries()).ToList();
            JobCategories = (await JobCategoryService.GetAllJobCategories()).ToList();

            CountryId = Employee.CountryId.ToString();
            JobCategoryId = Employee.JobCategoryId.ToString();

            int.TryParse(EmployeeId, out var employeeId);

            if (employeeId == 0) // if no employeeId has been passed via query params
            {
                // init new employee with some defaults
                Employee = new Employee { CountryId = 1, JobCategoryId = 1, BirthDate = DateTime.UtcNow, JoinedDate = DateTime.UtcNow };
            }
            else
            {
                Employee = await EmployeeService.GetEmployee(int.Parse(EmployeeId));
            }
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;
            Employee.CountryId = int.Parse(CountryId);
            Employee.JobCategoryId = int.Parse(JobCategoryId);

            if (Employee.EmployeeId == 0)
            {
                var addedEmployee = await EmployeeService.AddEmployee(Employee);
                if (addedEmployee != null)
                {
                    StatusClass = "alert-success";
                    Message = "New employee added successfully";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Something went wrong while trying to add employee.";
                    Saved = false;
                }
            }
            else
            {
                await EmployeeService.UpdateEmployee(Employee);
                StatusClass = "alert-success";
                Message = "New employee updated successfully";
                Saved = true;
            }
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "Validation error. Please check employee data and try again";
        }
    }
}
