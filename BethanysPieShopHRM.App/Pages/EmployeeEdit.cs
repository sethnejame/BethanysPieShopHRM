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
        public IEmployeeDataService EmployeeDataService { get; set; }

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

        protected async override Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
            Countries = (await CountryService.GetAllCountries()).ToList();
            JobCategories = (await JobCategoryService.GetAllJobCategories()).ToList();

            CountryId = Employee.CountryId.ToString();
            JobCategoryId = Employee.JobCategoryId.ToString();
        }
    }
}
