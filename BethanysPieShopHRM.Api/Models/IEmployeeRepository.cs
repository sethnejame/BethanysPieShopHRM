using BethanysPieShopHRM.Shared;
using System.Collections.Generic;

namespace BethanysPieShopHRM.Api.Models
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetTakeLongEmployeeList(int startIndex, int count);
        IEnumerable<Employee> GetLongEmployeeList();
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployeeById(int employeeId);
        Employee AddEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(int employeeId);
    }
}
