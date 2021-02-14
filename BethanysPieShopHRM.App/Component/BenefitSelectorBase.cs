using BethanysPieShopHRM.Shared;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using BethanysPieShopHRM.Server.Services;
using System.Threading.Tasks;
using System;

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

        protected async override Task OnInitializedAsync()
        {
            Benefits = await BenefitDataService.GetForEmployee(Employee);
        }

        public void CheckBoxChanged(ChangeEventArgs e, BenefitModel benefitModel)
        {
            var newValue = (bool)e.Value;
            benefitModel.Selected = newValue;
            SaveButtonDisabled = false;

            if(newValue)
            {
                benefitModel.StartDate = DateTime.UtcNow;
                benefitModel.EndDate = DateTime.UtcNow.AddYears(1);
            }
        }

        public void SaveClick()
        {
            BenefitDataService.UpdateForEmployee(Employee, Benefits);
            SaveButtonDisabled = true;
        }
    }
}
