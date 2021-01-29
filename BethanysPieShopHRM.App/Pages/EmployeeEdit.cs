using System;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;
using System.Collections.Generic;
using BethanysPieShopHRM.App.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.IO;

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
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Parameter]
        public string EmployeeId { get; set; }

        public Employee Employee { get; set; } = new Employee();
        public List<Country> Countries { get; set; } = new List<Country>();
        public List<JobCategory> JobCategories { get; set; } = new List<JobCategory>();

        protected string JobCategoryId = string.Empty;
        protected string CountryId = string.Empty;

        // used to store state of screen
        protected string Message = string.Empty;
        protected string StatusClass = string.Empty;
        protected bool Saved;

        private ElementReference LastNameInput;

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await LastNameInput.FocusAsync();
        }

        protected async override Task OnInitializedAsync()
        {
            Saved = false;
            Countries = (await CountryService.GetAllCountries()).ToList();
            JobCategories = (await JobCategoryService.GetAllJobCategories()).ToList();

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

            CountryId = Employee.CountryId.ToString();
            JobCategoryId = Employee.JobCategoryId.ToString();
        }

        private IReadOnlyList<IBrowserFile> selectedFiles;

        protected void OnInputFileChange(InputFileChangeEventArgs e)
        {
            selectedFiles = e.GetMultipleFiles();
            Message = $"{selectedFiles.Count} file(s) selected";
            StateHasChanged();
        }

        protected async Task HandleValidSubmit()
        {
            Saved = false;
            Employee.CountryId = int.Parse(CountryId);
            Employee.JobCategoryId = int.Parse(JobCategoryId);

            if (Employee.EmployeeId == 0)
            {
                if (selectedFiles != null)
                {
                    var file = selectedFiles[0];
                    Stream stream = file.OpenReadStream();
                    MemoryStream ms = new MemoryStream();
                    await stream.CopyToAsync(ms);
                    stream.Close();

                    Employee.ImageName = file.Name;
                    Employee.ImageContent = ms.ToArray();
                }

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

        protected async void DeleteEmployee()
        {
            await EmployeeService.DeleteEmployee(Employee.EmployeeId);

            StatusClass = "alert-success";
            Message = "Employee was successfully deleted.";

            Saved = true;
        }

        protected void HandleInvalidSubmit()
        {
            StatusClass = "alert-danger";
            Message = "Validation error. Please check employee data and try again";
        }

        protected void NavigateToOverview()
        {
            NavigationManager.NavigateTo("/employeeoverview");
        }

    }
}
