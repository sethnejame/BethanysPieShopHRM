using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;
using System.Collections.Generic;
using BethanysPieShopHRM.App.Services;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeDetail
    {
		[Parameter] // This is how we pass props from the parent component (the corresponding razor file)...in this case, the parent component's URL query params get passed down this way
        public string EmployeeId { get; set; }

		public EmployeeModel Employee { get; set; } = new EmployeeModel();

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
