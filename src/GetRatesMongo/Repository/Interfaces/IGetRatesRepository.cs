using System.Collections.Generic;
using System.Threading.Tasks;
using Models;

namespace Repository.Interfaces
{
    public interface IGetRatesRepository
    {
        Task<List<CountryRates>> GetReturnRates();
    }
}