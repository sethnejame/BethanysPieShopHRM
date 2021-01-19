using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.App.Services
{
    public class JobCategoryService : IJobCategoryService
    {
        private readonly HttpClient _httpClient;

        public JobCategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<JobCategory>> GetAllJobCategories()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<JobCategory>>
                (await _httpClient.GetStreamAsync($"api/jobcategory"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<JobCategory> GetJobCategoryById(int JobCategoryId)
        {
            return await JsonSerializer.DeserializeAsync<JobCategory>
               (await _httpClient.GetStreamAsync($"api/jobcategory/{JobCategoryId}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
