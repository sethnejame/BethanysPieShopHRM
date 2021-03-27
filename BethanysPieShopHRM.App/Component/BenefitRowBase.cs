using System;
using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Component
{
    public class BenefitRowBase : ComponentBase
    {
        [Parameter]
        public BenefitModel Benefit { get; set; }

        [Parameter]
        public EventCallback OnPremiumToggle { get; set; }

        public async Task Checked(ChangeEventArgs e, BenefitModel benefitModel)
        {
            var newValue = (bool)e.Value;
            benefitModel.Selected = newValue;

            if (newValue)
            {
                benefitModel.StartDate = DateTime.UtcNow;
                benefitModel.EndDate = DateTime.UtcNow.AddYears(1);
            }

            await OnPremiumToggle.InvokeAsync();
        }
    }
}
