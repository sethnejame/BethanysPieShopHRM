using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;
using System.Collections.Generic;
using BethanysPieShopHRM.App.Services;
using Microsoft.AspNetCore.Components;
using BethanysPieShopHRM.ComponentsLibrary.Map;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeDetail
    {
		[Parameter]
        public string EmployeeId { get; set; }

		public Employee Employee { get; set; } = new Employee();

        public List<Marker> MapMarkers { get; set; } = new List<Marker>();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        protected async override Task OnInitializedAsync()
		{
			Employee = await EmployeeService.GetEmployee(int.Parse(EmployeeId));
            MapMarkers = new List<Marker>
            {
                new Marker{Description = $"{Employee.FirstName} {Employee.LastName}", ShowPopup = false, X = Employee.Longitude, Y = Employee.Latitude}
            };
		}
	}
}
