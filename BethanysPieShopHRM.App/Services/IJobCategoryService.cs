using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.App.Services
{
    public interface IJobCategoryService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();

        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
