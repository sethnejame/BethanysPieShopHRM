using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.App.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;
        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<EmployeeModel> AddEmployee(EmployeeModel employee)
        {
            var employeeJson =
                new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/employee", employeeJson);

            if (response.IsSuccessStatusCode) 
            {
                return await JsonSerializer.DeserializeAsync<EmployeeModel>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task DeleteEmployee(int employeeId)
        {
            await _httpClient.DeleteAsync($"api/employee/{employeeId}");
        }

        public async Task<IEnumerable<EmployeeModel>> GetAllEmployees()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<EmployeeModel>>
                (await _httpClient.GetStreamAsync($"api/employee"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<IEnumerable<EmployeeModel>> GetLongEmployeeList()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeModel>>($"api/employee/long");
        }

        public async Task<IEnumerable<EmployeeModel>> GetTakeLongEmployeeList(int startIndex, int count)
        {
            return await _httpClient.GetFromJsonAsync<List<EmployeeModel>>($"api/employee/long/{startIndex}/{count}");
        }

        public async Task<EmployeeModel> GetEmployee(int employeeId)
        {
            return await JsonSerializer.DeserializeAsync<EmployeeModel>
                (await _httpClient.GetStreamAsync($"api/employee/{employeeId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateEmployee(EmployeeModel employee)
        {
            var employeeJson =
                new StringContent(JsonSerializer.Serialize(employee), Encoding.UTF8, "application/json");


            await _httpClient.PutAsync("api/employee", employeeJson);
        }
    }
}
