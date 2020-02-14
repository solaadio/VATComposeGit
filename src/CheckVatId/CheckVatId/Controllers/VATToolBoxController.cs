using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;
using ServiceReference1;

namespace MyFirstDotNetCoreApp.Controllers
{

    [Route("VATToolBox")]
    // ReSharper disable once InconsistentNaming
    public class VATToolBoxController : Controller
    {

        [HttpGet]
        [Route("CheckVatId/{countryCode}/{vatNumber}")]
        public async Task<ResponseObject> ValidateVatId(string countryCode, string vatNumber)
        {
            var checkVatService = new checkVatPortTypeClient();
            var responseObject = new ResponseObject();

            try
            {
                // uncomment to shut this endpoint down
                // throw new Exception("UPGRADE_NOW");
                string countryCode1 = countryCode.ToUpper();
                var response = await checkVatService.checkVatAsync(new checkVatRequest(countryCode1, vatNumber));

                responseObject.IsValid = response.valid;
                if (response.valid)
                {
                    responseObject.Name = response.name;
                    responseObject.Address = response.address;
                }
            }
            catch (Exception exception)
            {
                responseObject.ServerResponse = exception.Message;
            }

            return responseObject;
        }    }


}
