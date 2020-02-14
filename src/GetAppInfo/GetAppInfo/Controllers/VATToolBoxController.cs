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
        [Route("GetLatestRatesVersion")]
        public RateVersion GetRatesVersion()
        {
            //            var rateVersion = new RateVersion { Version = 2.02, VersionDate = new DateTime(2013, 01, 12).ToString("yyyyMMdd"), Status = "OK" };
            var rateVersion = new RateVersion { Version = 3.51, VersionDate = new DateTime(2017, 01, 22).ToString("yyyyMMdd") };
            // uncomment to shut this endpoint down
            //                var rateVersion = new RateVersion { Version = 2.06, VersionDate = new DateTime(2013, 01, 16).ToString("yyyyMMdd"), Status = "UPGRADE_NOW" };
            return rateVersion;
        }

        [HttpGet]
        [Route("GetWhatsNewInfoMore/{versionId}/")]
        public WhatsNewResultMore GetWhatsNewMore(string versionId)
        {
            var messages = new List<WhatsNewResultMore>
                               {
                                   new WhatsNewResultMore
                                       {
                                           Body =
                                               "Minor Bug fixes",
                                           ButtonTitle = "Ok",
                                           NotificationId = 1,
                                           Title = "What's new in V2.18",
                                           VersionId = "2.18"
                                       },

                                   new WhatsNewResultMore
                                       {
                                           Body =
                                               "2 new In-App Purchases added to VAT Toolbox. \n"
                                               + "1.   20,000 Tap bundle for those who use the Tap system. \n"
                                               + "2.   Unlimited Use - This single purchase grants you UNLIMITED access to ALL VAT Toolbox screens across ALL your devices. "
                                               + "This eliminates the need to buy any screens or Taps. \n\n\n"
                                               + "Introductory Taps now increased from 30 to 3,000 for NEW users.",
                                           ButtonTitle = "Ok",
                                           NotificationId = 1,
                                           Title = "What's new in V2.17",
                                           VersionId = "2.17"
                                       },

                                   new WhatsNewResultMore
                                       {
                                           Body =
                                               "A new modal screen that displays your tap usage has been added to the Store page. Please tap on the 'Log' icon at the top right corner of the Store page to reveal the Tap Log screen.",
                                           ButtonTitle = "Ok",
                                           NotificationId = 1,
                                           Title = "What's new in V2.15",
                                           VersionId = "2.15"
                                       },
                                  new WhatsNewResultMore
                                       {
                                           Body =
                                               "Maintenance Release to prepare for iOS7",
                                           ButtonTitle = "Ok",
                                           NotificationId = 1,
                                           Title = "What's new in V2.19",
                                           VersionId = "2.19"
                                       },
                                  new WhatsNewResultMore
                                       {
                                           Body =
                                               "VAT Toolbox is now fully optimised for iOS7",
                                           ButtonTitle = "Ok",
                                           NotificationId = 1,
                                           Title = "What's new in V3.00",
                                           VersionId = "3.00"
                                       },
                                  new WhatsNewResultMore
                                       {
                                           Body =
                                               "Minor UI tweaks on the Settings page.",
                                           ButtonTitle = "Ok",
                                           NotificationId = 1,
                                           Title = "What's new in V3.01",
                                           VersionId = "3.01"
                                       },
                                  new WhatsNewResultMore
                                       {
                                           Body =
                                               "Minor UI tweaks on the In-App purchase page.",
                                           ButtonTitle = "Ok",
                                           NotificationId = 1,
                                           Title = "What's new in V3.02",
                                           VersionId = "3.02"
                                       },
                                  new WhatsNewResultMore
                                       {
                                           Body =
                                               "Updated for iOS 8 to iOS10.",
                                           ButtonTitle = "Ok",
                                           NotificationId = 1,
                                           Title = "What's new in V3.50",
                                           VersionId = "3.50"
                                       },
                                  new WhatsNewResultMore
                                       {
                                           Body = "Minor UI tweaks.",
                                           ButtonTitle = "Ok",
                                           NotificationId = 1,
                                           Title = "What's new in V3.51",
                                           VersionId = "3.51"
                                       },
                                  new WhatsNewResultMore
                                       {
                                           Body = "Minor Release.",
                                           ButtonTitle = "Ok",
                                           NotificationId = 1,
                                           Title = "What's new in V3.52",
                                           VersionId = "3.52"
                                       }



                               };
            return messages.First(msg => msg.VersionId == versionId);
        }


        [HttpGet]
        [Route("GetLeastVersion")]
        public VATVersionObject GetEarliestAllowedVersion()
        {
            var allowed = new VATVersionObject
            {
                Message = "You are running an unsupported version of VAT Toolbox." +
                                            " Please download the latest version from the App Store to ensure that VAT Toolbox runs without problems ",
                VersionId = 3.50

            };
            return allowed;
        }

    }


}
