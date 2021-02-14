using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;
using System.Collections.Generic;

namespace BethanysPieShopHRM.Server.Services
{
    public interface IBenefitDataService
    {
        Task<IEnumerable<BenefitModel>> GetForEmployee(EmployeeModel employee);
        Task UpdateForEmployee(EmployeeModel employee, IEnumerable<BenefitModel> benefits);
    }
}