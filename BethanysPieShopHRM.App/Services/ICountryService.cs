using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.App.Services
{
    public interface ICountryService
    {
        Task<IEnumerable<Country>> GetAllCountries();

        Task<Country> GetCountryById(int CountryId);

    }
}
