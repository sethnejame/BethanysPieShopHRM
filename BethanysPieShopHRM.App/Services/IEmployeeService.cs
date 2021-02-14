using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.App.Services
{
    public  interface IEmployeeService
    {
        Task<IEnumerable<EmployeeModel>> GetLongEmployeeList();

        Task<IEnumerable<EmployeeModel>> GetTakeLongEmployeeList(int startIndex, int count);

        Task<IEnumerable<EmployeeModel>> GetAllEmployees();

        Task<EmployeeModel> GetEmployee(int employeeId);

        Task<EmployeeModel> AddEmployee(EmployeeModel employee);

        Task UpdateEmployee(EmployeeModel employee);

        Task DeleteEmployee(int employeeId);
    }
}
