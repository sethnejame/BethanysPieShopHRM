using BethanysPieShopHRM.Shared;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using BethanysPieShopHRM.Server.Services;
using System.Threading.Tasks;
using System;
using System.Linq;

namespace BethanysPieShopHRM.App.Component
{
    public class BenefitSelectorBase : ComponentBase
    {
        protected IEnumerable<BenefitModel> Benefits { get; set; }

        [Inject] // regular constructor injection doesnt work 
        public IBenefitDataService BenefitDataService { get; set; }

        [Parameter]
        public EmployeeModel Employee { get; set; }

        protected bool SaveButtonDisabled { get; set; } = true;

        [Parameter]
        public EventCallback<bool> OnPremiumToggle { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Benefits = await BenefitDataService.GetForEmployee(Employee);
        }

        public async Task CheckBoxChanged()
        {
            SaveButtonDisabled = false;

            await OnPremiumToggle.InvokeAsync(Benefits.Any(x => x.Premium && x.Selected)); // This is how we change parent props
        }

        public void SaveClick()
        {
            BenefitDataService.UpdateForEmployee(Employee, Benefits);
            SaveButtonDisabled = true;
        }
    }
}
