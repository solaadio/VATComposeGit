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
        [HttpPost]
        [Route("SendFeedback")]
        public async Task<AppUserMessageResponse> SendFeedback([FromBody]AppUserMessage message)
        {
            try
            {
                var formContent = new StringContent(JsonConvert.SerializeObject(message), Encoding.ASCII,
                    "application/json");

                HttpClient myHttpClient = new HttpClient
                {
                    BaseAddress = new Uri(
                        "https://prod-07.westeurope.logic.azure.com:443/workflows/4b8767e51a7a4345aae216ca0146e0c0/triggers/manual/run?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=-9MtJG7KT2vTbxFMnEytN1a7cpw-TNise7OpLTMgTn4")
                };
                var response = await myHttpClient.PostAsync("", formContent);

                var stringContent = await response.Content.ReadAsStringAsync();

                var responseObject = JsonConvert.DeserializeObject<AppUserMessageResponse>(stringContent);

                return responseObject;
            }
            catch (Exception ex)
            {
                return new AppUserMessageResponse { Success = false, Message = ex.Message };
            }

        }
    }


}
