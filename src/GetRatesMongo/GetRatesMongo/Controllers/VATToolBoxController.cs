using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;
using Repository.Implementation;
using Repository.Interfaces;
using ServiceReference1;

namespace MyFirstDotNetCoreApp.Controllers
{

    [Route("VATToolBox")]
    // ReSharper disable once InconsistentNaming
    public class VATToolBoxController : Controller
    {

        [HttpGet]
        [Route("GetRates")]
        public async Task<IEnumerable<CountryRates>> GetRates()
        {
            IGetRatesRepository repo = new GetRatesFromMongoDbRepo();
            var rates = await repo.GetReturnRates();
            return rates;
        }


    }


}
