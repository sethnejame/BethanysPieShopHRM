using BethanysPieShopHRM.Shared;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using BethanysPieShopHRM.Server.Services;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.App.Component
{
    public class BenefitSelectorBase : ComponentBase
    {
        protected IEnumerable<BenefitModel> Benefits { get; set; }

        [Inject] // regular constructor injection doesnt work 
        public IBenefitDataService BenefitDataService { get; set; }

        [Parameter]
        public EmployeeModel Employee { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Benefits = await BenefitDataService.GetForEmployee(Employee);
        }
    }
}
