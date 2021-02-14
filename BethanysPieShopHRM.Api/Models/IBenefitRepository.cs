using BethanysPieShopHRM.Shared;
using System.Collections.Generic;

namespace BethanysPieShopHRM.Api.Models
{
    public interface IBenefitRepository
    {
        IEnumerable<BenefitModel> GetForEmployee(int employeeId);
        void UpdateForEmployee(int employeeId, IEnumerable<BenefitModel> model);
    }
}
