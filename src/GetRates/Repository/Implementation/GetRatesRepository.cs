using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Repository.Interfaces;

namespace Repository.Implementation
{
    public class GetRatesRepository : IGetRatesRepository
    {
        public async Task<List<CountryRates>> GetReturnRates()
        {
            // Eurpoe
            var atRates = new List<double> {0.0, 10.0, 12.0, 20.0};
            var beRates = new List<double> {0.00, 6.0, 12.0, 21.0};
            var bgRates = new List<double> {0.00, 0.0, 9.0, 20.0};
            var cyRates = new List<double> {0.00, 5.0, 8.0, 18.0};
            var czRates = new List<double> {0.00, 0.0, 15.0, 21.0};
            var dkRates = new List<double> {0.00, 0.0, 0.0, 25.0};
            var eeRates = new List<double> {0.00, 0.0, 9.0, 20.0};
            var fiRates = new List<double> {0.00, 10.0, 14.0, 24.0};
            var frRates = new List<double> {2.1, 5.5, 7.0, 19.6};
            var deRates = new List<double> {0.00, 0.0, 7.0, 19.0};
            var elRates = new List<double> {0.00, 6.5, 13.0, 23.0};
            var huRates = new List<double> {5.00, 18.0, 25.0, 27.0};
            var ieRates = new List<double> {4.8, 13.5, 21.0, 23.0};
            var itRates = new List<double> {0.00, 4.0, 10.0, 21.0};
            var lvRates = new List<double> {0.00, 1.0, 12.0, 21.0};
            var ltRates = new List<double> {0.00, 5.0, 9.0, 21.0};
            var luRates = new List<double> {6.0, 9.0, 12.0, 15.0};
            var mtRates = new List<double> {0.00, 5.0, 17.0, 18.0};
            var nlRates = new List<double> {0.00, 0.0, 6.0, 21.0};
            var noRates = new List<double> {0, 8, 15, 25};
            var plRates = new List<double> {0.00, 5.0, 8.0, 23.0};
            var ptRates = new List<double> {0.00, 6.0, 13.0, 23.0};
            var roRates = new List<double> {0.00, 5.0, 9.0, 24.0};
            var skRates = new List<double> {0.00, 0.0, 10.0, 20.0};
            var siRates = new List<double> {0.0, 0.0, 8.5, 22.0};
            var esRates = new List<double> {4.00, 10.0, 18.0, 21.0};
            var seRates = new List<double> {0.00, 6.0, 12.0, 25.0};
            var gbRates = new List<double> {5.0, 15.0, 17.5, 20.0};
            var zzRates = new List<double> {5.0, 15.0, 17.5, 20.0};

            var atRate = new CountryRates
            {
                Country = "AT",
                Rates = atRates,
                LongName = "Austria",
                StdRate = 3,
                UseForValidation = true,
                Section = 0
            };
            var beRate = new CountryRates
            {
                Country = "BE",
                LongName = "Belgium",
                Rates = beRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var bgRate = new CountryRates
            {
                Country = "BG",
                LongName = "Bulgaria",
                Rates = bgRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };

            var cyRate = new CountryRates
            {
                Country = "CY",
                LongName = "Cyprus",
                Rates = cyRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var czRate = new CountryRates
            {
                Country = "CZ",
                LongName = "Czech Republic",
                Rates = czRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var dkRate = new CountryRates
            {
                Country = "DK",
                Rates = dkRates,
                LongName = "Denmark",
                UseForValidation = true,
                Section = 0,
                StdRate = 3
            };
            var eeRate = new CountryRates
            {
                Country = "EE",
                LongName = "Estonia",
                Rates = eeRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var fiRate = new CountryRates
            {
                Country = "FI",
                LongName = "Finland",
                Rates = fiRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var elRate = new CountryRates
            {
                Country = "EL",
                LongName = "Greece",
                Rates = elRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var huRate = new CountryRates
            {
                Country = "HU",
                Rates = huRates,
                LongName = "Hungary",
                UseForValidation = true,
                Section = 0,
                StdRate = 3
            };
            var ieRate = new CountryRates
            {
                Country = "IE",
                LongName = "Ireland",
                Rates = ieRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var itRate = new CountryRates
            {
                Country = "IT",
                LongName = "Italy",
                Rates = itRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var lvRate = new CountryRates
            {
                Country = "LV",
                LongName = "Latvia",
                Rates = lvRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var ltRate = new CountryRates
            {
                Country = "LT",
                LongName = "Lithuania",
                Rates = ltRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var luRate = new CountryRates
            {
                Country = "LU",
                LongName = "Luxembourg",
                Rates = luRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var mtRate = new CountryRates
            {
                Country = "MT",
                LongName = "Malta",
                Rates = mtRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var nlRate = new CountryRates
            {
                Country = "NL",
                LongName = "Netherlands",
                Rates = nlRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };

            var noRate = new CountryRates
            {
                Country = "W-NOR",
                Rates = noRates,
                LongName = "Norway",
                Section = 0,
                StdRate = 3,
                UseForValidation = false
            };

            var plRate = new CountryRates
            {
                Country = "PL",
                LongName = "Poland",
                Rates = plRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var ptRate = new CountryRates
            {
                Country = "PT",
                LongName = "Portugal",
                Rates = ptRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var roRate = new CountryRates
            {
                Country = "RO",
                LongName = "Romania",
                Rates = roRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var skRate = new CountryRates
            {
                Country = "SK",
                LongName = "Slovakia",
                Rates = skRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var siRate = new CountryRates
            {
                Country = "SI",
                LongName = "Slovenia",
                Rates = siRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var esRate = new CountryRates
            {
                Country = "ES",
                LongName = "Spain",
                Rates = esRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var seRate = new CountryRates
            {
                Country = "SE",
                LongName = "Sweden",
                Rates = seRates,
                Section = 0,
                UseForValidation = true,
                StdRate = 3
            };
            var gbRate = new CountryRates
            {
                Country = "GB",
                Rates = gbRates,
                LongName = "United Kingdom",
                UseForValidation = true,
                Section = 0,
                StdRate = 3
            };
            var frRate = new CountryRates
            {
                Country = "FR",
                Rates = frRates,
                LongName = "France",
                UseForValidation = true,
                Section = 0,
                StdRate = 3
            };
            var deRate = new CountryRates
            {
                Country = "DE",
                Rates = deRates,
                LongName = "Germany",
                UseForValidation = true,
                Section = 0,
                StdRate = 3
            };


            // custom
            var zzRate = new CountryRates
            {
                Country = "ZZ",
                Rates = zzRates,
                LongName = "Custom",
                UseForValidation = false,
                Section = 1,
                StdRate = 3
            };


            // US
            var alRate = new CountryRates
            {
                Country = "US-AL",
                Rates = new List<double> {0.0, 0.0, 0.0, 4.0},
                LongName = "Alabama",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var arRate = new CountryRates
            {
                Country = "US-AR",
                Rates = new List<double> {0.0, 0.0, 0.0, 5.6},
                LongName = "Arizona",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var akRate = new CountryRates
            {
                Country = "US-AK",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.0},
                LongName = "Arkansas",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var caRate = new CountryRates
            {
                Country = "US-CA",
                Rates = new List<double> {0.0, 0.0, 0.0, 8.25},
                LongName = "California",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usCoRate = new CountryRates
            {
                Country = "US-CO",
                Rates = new List<double> {0.0, 0.0, 0.0, 2.90},
                LongName = "Colorado",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usCtRate = new CountryRates
            {
                Country = "US-CT",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.0},
                LongName = "Connecticut",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usDlRate = new CountryRates
            {
                Country = "US-DL",
                Rates = new List<double> {0.0, 0.0, 0.0, 2.07},
                LongName = "Delaware",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usFlRate = new CountryRates
            {
                Country = "US-FL",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.0},
                LongName = "Florida",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usGaRate = new CountryRates
            {
                Country = "US-GA",
                Rates = new List<double> {0.0, 0.0, 0.0, 4.0},
                LongName = "Georgia",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usHaRate = new CountryRates
            {
                Country = "US-HA",
                Rates = new List<double> {0.0, 0.0, 0.0, 4.0},
                LongName = "Hawaii",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usIdRate = new CountryRates
            {
                Country = "US-ID",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.0},
                LongName = "Idaho",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usIlRate = new CountryRates
            {
                Country = "US-IL",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.25},
                LongName = "Illinois",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usInRate = new CountryRates
            {
                Country = "US-IN",
                Rates = new List<double> {0.0, 0.0, 0.0, 7.0},
                LongName = "Indiana",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usIoRate = new CountryRates
            {
                Country = "US-IO",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.0},
                LongName = "Iowa",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usKaRate = new CountryRates
            {
                Country = "US-KA",
                Rates = new List<double> {0.0, 0.0, 0.0, 5.3},
                LongName = "Kansas",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usKtRate = new CountryRates
            {
                Country = "US-KT",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.0},
                LongName = "Kentucky",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usLoRate = new CountryRates
            {
                Country = "US-LO",
                Rates = new List<double> {0.0, 0.0, 0.0, 4.0},
                LongName = "Louisiana",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usMaRate = new CountryRates
            {
                Country = "US-MA",
                Rates = new List<double> {0.0, 0.0, 0.0, 5.0},
                LongName = "Maine",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usMdRate = new CountryRates
            {
                Country = "US-MD",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.0},
                LongName = "Maryland",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usMtRate = new CountryRates
            {
                Country = "US-MT",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.25},
                LongName = "Massachusetts",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usMiRate = new CountryRates
            {
                Country = "US-MI",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.0},
                LongName = "Michigan",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usMnRate = new CountryRates
            {
                Country = "US-MN",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.875},
                LongName = "Minnesota",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usMsRate = new CountryRates
            {
                Country = "US-MS",
                Rates = new List<double> {0.0, 0.0, 0.0, 7.0},
                LongName = "Mississippi",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usMrRate = new CountryRates
            {
                Country = "US-MR",
                Rates = new List<double> {0.0, 0.0, 0.0, 4.225},
                LongName = "Missouri",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usNeRate = new CountryRates
            {
                Country = "US-NE",
                Rates = new List<double> {0.0, 0.0, 0.0, 5.50},
                LongName = "Nebraska",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usNvRate = new CountryRates
            {
                Country = "US-NV",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.85},
                LongName = "Nevada",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usNjRate = new CountryRates
            {
                Country = "US-NJ",
                Rates = new List<double> {0.0, 0.0, 0.0, 7.0},
                LongName = "New Jersey",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usNmRate = new CountryRates
            {
                Country = "US-NM",
                Rates = new List<double> {0.0, 0.0, 0.0, 5.375},
                LongName = "New Mexico",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usNyRate = new CountryRates
            {
                Country = "US-NY",
                Rates = new List<double> {0.0, 0.0, 0.0, 4.0},
                LongName = "New York",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usNcRate = new CountryRates
            {
                Country = "US-NC",
                Rates = new List<double> {0.0, 0.0, 0.0, 4.5},
                LongName = "North Carolina",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usNdRate = new CountryRates
            {
                Country = "US-ND",
                Rates = new List<double> {0.0, 0.0, 0.0, 5.0},
                LongName = "North Dakota",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usOhRate = new CountryRates
            {
                Country = "US-OH",
                Rates = new List<double> {0.0, 0.0, 0.0, 5.5},
                LongName = "Ohio",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usOkRate = new CountryRates
            {
                Country = "US-OK",
                Rates = new List<double> {0.0, 0.0, 0.0, 4.5},
                LongName = "Oklahoma",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usPnRate = new CountryRates
            {
                Country = "US-PN",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.0},
                LongName = "Pennsylvania",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usRoRate = new CountryRates
            {
                Country = "US-RO",
                Rates = new List<double> {0.0, 0.0, 0.0, 7.0},
                LongName = "Rhode Island",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usScRate = new CountryRates
            {
                Country = "US-SC",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.0},
                LongName = "South Carolina",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usSdRate = new CountryRates
            {
                Country = "US-SD",
                Rates = new List<double> {0.0, 0.0, 0.0, 4.0},
                LongName = "South Dakota",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usTnRate = new CountryRates
            {
                Country = "US-TN",
                Rates = new List<double> {0.0, 0.0, 0.0, 7.0},
                LongName = "Tennessee",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usTxRate = new CountryRates
            {
                Country = "US-TX",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.25},
                LongName = "Texas",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usUtRate = new CountryRates
            {
                Country = "US-UT",
                Rates = new List<double> {0.0, 0.0, 0.0, 5.95},
                LongName = "Utah",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };

            var usVeRate = new CountryRates
            {
                Country = "US-VE",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.0},
                LongName = "Vermont",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usViRate = new CountryRates
            {
                Country = "US-VI",
                Rates = new List<double> {0.0, 0.0, 0.0, 5.00},
                LongName = "Virginia",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usWvRate = new CountryRates
            {
                Country = "US-WV",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.00},
                LongName = "West Virginia",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usWsRate = new CountryRates
            {
                Country = "US-WS",
                Rates = new List<double> {0.0, 0.0, 0.0, 5.00},
                LongName = "Wisconsin",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usWaRate = new CountryRates
            {
                Country = "US-WA",
                Rates = new List<double> {0.0, 0.0, 0.0, 6.50},
                LongName = "Washington",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usDcRate = new CountryRates
            {
                Country = "US-DC",
                Rates = new List<double> {0.0, 0.0, 0.0, 5.75},
                LongName = "Washington DC",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };
            var usWyRate = new CountryRates
            {
                Country = "US-WY",
                Rates = new List<double> {0.0, 0.0, 0.0, 4.00},
                LongName = "Wyoming",
                Section = 2,
                StdRate = 3,
                UseForValidation = false
            };


            var wSwRate = new CountryRates
            {
                Country = "W-SW",
                Rates = new List<double> {2.40, 3.60, 7.6, 0.0},
                LongName = "Switzerland",
                Section = 3,
                StdRate = 2,
                UseForValidation = false
            };


            var wAlRate = new CountryRates
            {
                Country = "W-AL",
                Rates = new List<double> {0, 0, 0, 20.00},
                LongName = "Albania",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };

            var wArRate = new CountryRates
            {
                Country = "W-AR",
                Rates = new List<double> {0, 0, 10.5, 21},
                LongName = "Argentina",
                Section = 3,
                StdRate = 2,
                UseForValidation = false
            };

            var wArmRate = new CountryRates
            {
                Country = "W-ARM",
                Rates = new List<double> {0, 0, 0, 20},
                LongName = "Armenia",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };

            var wAusRate = new CountryRates
            {
                Country = "W-AUS",
                Rates = new List<double> {0, 0, 0, 10},
                LongName = "Australia",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };

            var wBarRate = new CountryRates
            {
                Country = "W-BAR",
                Rates = new List<double> {0, 0, 0, 15},
                LongName = "Barbados",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wBolRate = new CountryRates
            {
                Country = "W-BOL",
                Rates = new List<double> {0, 0, 13, 14.94},
                LongName = "Bolivia",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wBosRate = new CountryRates
            {
                Country = "W-BOS",
                Rates = new List<double> {0, 0, 0, 17},
                LongName = "Bosnia",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wBraRate = new CountryRates
            {
                Country = "W-BRA",
                Rates = new List<double> {0, 5, 12, 25},
                LongName = "Brasil",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wChilRate = new CountryRates
            {
                Country = "W-CHIL",
                Rates = new List<double> {0, 0, 0, 19},
                LongName = "Chile",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wChinRate = new CountryRates
            {
                Country = "W-CHIN",
                Rates = new List<double> {0, 3, 6, 17},
                LongName = "China",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wColRate = new CountryRates
            {
                Country = "W-COL",
                Rates = new List<double> {0, 0, 0, 16},
                LongName = "Colombia",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wCroRate = new CountryRates
            {
                Country = "W-CRO",
                Rates = new List<double> {0, 0, 10, 23},
                LongName = "Croatia",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wDomiRate = new CountryRates
            {
                Country = "W-DOMI",
                Rates = new List<double> {0, 0, 12, 16},
                LongName = "Dominican Republic",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wEcuRate = new CountryRates
            {
                Country = "W-ECU",
                Rates = new List<double> {0, 0, 0, 12},
                LongName = "Ecuador",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };

            var wEgptRate = new CountryRates
            {
                Country = "W-EGPT",
                Rates = new List<double> {0, 0, 0, 10},
                LongName = "Egypt",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wElsalRate = new CountryRates
            {
                Country = "W-ELSAL",
                Rates = new List<double> {0, 0, 0, 13},
                LongName = "El Salvador",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wFijiRate = new CountryRates
            {
                Country = "W-FIJI",
                Rates = new List<double> {0, 0, 0, 12.5},
                LongName = "Fiji",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wGeorRate = new CountryRates
            {
                Country = "W-GEOR",
                Rates = new List<double> {0, 0, 0, 18},
                LongName = "Georgia",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wGuatRate = new CountryRates
            {
                Country = "W-GUAT",
                Rates = new List<double> {0, 0, 0, 12},
                LongName = "Guatemala",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wGuyaRate = new CountryRates
            {
                Country = "W-GUYA",
                Rates = new List<double> {0, 0, 0, 16},
                LongName = "Guyana",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wIceRate = new CountryRates
            {
                Country = "W-ICE",
                Rates = new List<double> {0, 0, 24.5, 7},
                LongName = "Iceland",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wIndRate = new CountryRates
            {
                Country = "W-IND",
                Rates = new List<double> {0, 0, 4, 14},
                LongName = "India",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wIndoRate = new CountryRates
            {
                Country = "W-INDO",
                Rates = new List<double> {0, 0, 5, 10},
                LongName = "Indonesia",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wIsrRate = new CountryRates
            {
                Country = "W-ISR",
                Rates = new List<double> {0, 0, 0, 16},
                LongName = "Israel",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wJapRate = new CountryRates
            {
                Country = "W-JAP",
                Rates = new List<double> {0, 0, 0, 5},
                LongName = "Japan",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };

            var wJordRate = new CountryRates
            {
                Country = "W-JORD",
                Rates = new List<double> {0, 0, 0, 16},
                LongName = "Jordan",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wKazaRate = new CountryRates
            {
                Country = "W-KAZA",
                Rates = new List<double> {0, 0, 0, 12},
                LongName = "Kazakhstan",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wLebaRate = new CountryRates
            {
                Country = "W-LEBA",
                Rates = new List<double> {0, 0, 0, 10},
                LongName = "Lebanon",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wMaceRate = new CountryRates
            {
                Country = "W-MACE",
                Rates = new List<double> {0, 0, 5, 18},
                LongName = "Macedonia",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wMalayRate = new CountryRates
            {
                Country = "W-MALAY",
                Rates = new List<double> {0, 0, 0, 10},
                LongName = "Malaysia",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wMaurRate = new CountryRates
            {
                Country = "W-MAUR",
                Rates = new List<double> {0, 0, 0, 15},
                LongName = "Mauritius",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wMexRate = new CountryRates
            {
                Country = "W-MEX",
                Rates = new List<double> {0, 0, 0, 16},
                LongName = "Mexico",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wMoldRate = new CountryRates
            {
                Country = "W-MOLD",
                Rates = new List<double> {0, 5, 8, 20},
                LongName = "Moldova",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wMorocRate = new CountryRates
            {
                Country = "W-MOROC",
                Rates = new List<double> {0, 0, 0, 20},
                LongName = "Morocco",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wNewzRate = new CountryRates
            {
                Country = "W-NEWZ",
                Rates = new List<double> {0, 0, 0, 12.5},
                LongName = "New Zealand",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wNgnRate = new CountryRates
            {
                Country = "W-NGN",
                Rates = new List<double> {0, 0, 0, 5},
                LongName = "Nigeria",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wPakiRate = new CountryRates
            {
                Country = "W-PAKI",
                Rates = new List<double> {0, 0, 1, 16},
                LongName = "Pakistan",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wPanaRate = new CountryRates
            {
                Country = "W-PANA",
                Rates = new List<double> {0, 0, 0, 5},
                LongName = "Panama",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wParaRate = new CountryRates
            {
                Country = "W-PARA",
                Rates = new List<double> {0, 0, 5, 10},
                LongName = "Paraguay",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wPeruRate = new CountryRates
            {
                Country = "W-PERU",
                Rates = new List<double> {0, 0, 0, 19},
                LongName = "Peru",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wPhilRate = new CountryRates
            {
                Country = "W-PHIL",
                Rates = new List<double> {0, 0, 0, 12},
                LongName = "Philippines",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wRussRate = new CountryRates
            {
                Country = "W-RUSS",
                Rates = new List<double> {0, 0, 10, 18},
                LongName = "Russia",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wSerbRate = new CountryRates
            {
                Country = "W-SER",
                Rates = new List<double> {0, 0, 8, 18},
                LongName = "Serbia",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wSingRate = new CountryRates
            {
                Country = "W-SING",
                Rates = new List<double> {0, 0, 0, 7},
                LongName = "Singapore",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wSaRate = new CountryRates
            {
                Country = "W-SA",
                Rates = new List<double> {0, 0, 0, 14},
                LongName = "South Africa",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wSkRate = new CountryRates
            {
                Country = "W-SK",
                Rates = new List<double> {0, 0, 0, 10},
                LongName = "South Korea",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wSriRate = new CountryRates
            {
                Country = "W-SRI",
                Rates = new List<double> {0, 0, 0, 12},
                LongName = "Sri Lanka",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wThaiRate = new CountryRates
            {
                Country = "W-THAI",
                Rates = new List<double> {0, 0, 0, 7},
                LongName = "Thailand",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wTntRate = new CountryRates
            {
                Country = "W-TNT",
                Rates = new List<double> {0, 0, 0, 15},
                LongName = "Trinidad & Tobago",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wTurkRate = new CountryRates
            {
                Country = "W-TURK",
                Rates = new List<double> {0, 1, 8, 18},
                LongName = "Turkey",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wUkrRate = new CountryRates
            {
                Country = "W-UKR",
                Rates = new List<double> {0, 0, 0, 20},
                LongName = "Ukraine",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wUruRate = new CountryRates
            {
                Country = "W-URU",
                Rates = new List<double> {0, 0, 10, 22},
                LongName = "Uruguay",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wVeneRate = new CountryRates
            {
                Country = "W-VENE",
                Rates = new List<double> {0, 0, 11, 12},
                LongName = "Venezuela",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };


            var wVietRate = new CountryRates
            {
                Country = "W-VIET",
                Rates = new List<double> {0, 0, 0, 10},
                LongName = "Vietnam",
                Section = 3,
                StdRate = 3,
                UseForValidation = false
            };

            // Canada
            var caAlRate = new CountryRates
            {
                Country = "CA-AL",
                Rates = new List<double> {0, 0, 0, 5},
                LongName = "Alberta",
                Section = 4,
                StdRate = 3,
                UseForValidation = false
            };

            var caBcRate = new CountryRates
            {
                Country = "CA-BC",
                Rates = new List<double> {0, 7, 5, 12},
                LongName = "British Columbia",
                Section = 4,
                StdRate = 3,
                UseForValidation = false
            };


            var caMtRate = new CountryRates
            {
                Country = "CA-MT",
                Rates = new List<double> {0, 7, 5, 12},
                LongName = "Manitoba",
                Section = 4,
                StdRate = 3,
                UseForValidation = false
            };

            var caNbRate = new CountryRates
            {
                Country = "CA-NB",
                Rates = new List<double> {0, 8, 5, 13},
                LongName = "New Brunswick",
                Section = 4,
                StdRate = 3,
                UseForValidation = false
            };

            var caNfRate = new CountryRates
            {
                Country = "CA-NF",
                Rates = new List<double> {0, 8, 5, 13},
                LongName = "Newfoundland",
                Section = 4,
                StdRate = 3,
                UseForValidation = false
            };

            var caNsRate = new CountryRates
            {
                Country = "CA-NS",
                Rates = new List<double> {0, 10, 5, 15},
                LongName = "Nova Scotia",
                Section = 4,
                StdRate = 3,
                UseForValidation = false
            };


            var caOnRate = new CountryRates
            {
                Country = "CA-ON",
                Rates = new List<double> {0, 8, 5, 13},
                LongName = "Ontario",
                Section = 4,
                StdRate = 3,
                UseForValidation = false
            };

            var caPeiRate = new CountryRates
            {
                Country = "CA-PEI",
                Rates = new List<double> {10, 10.5, 5, 15},
                LongName = "Prince Edward Island",
                Section = 4,
                StdRate = 3,
                UseForValidation = false
            };

            var caQuRate = new CountryRates
            {
                Country = "CA-QU",
                Rates = new List<double> {8.5, 9.975, 5, 14.975},
                LongName = "Quebec",
                Section = 4,
                StdRate = 3,
                UseForValidation = false
            };

            var caSaRate = new CountryRates
            {
                Country = "CA-SA",
                Rates = new List<double> {0, 5, 5, 10},
                LongName = "Saskatchewan",
                Section = 4,
                StdRate = 3,
                UseForValidation = false
            };


            var euRates = new List<CountryRates>();


            // Europe & Custom
            euRates.AddRange(new List<CountryRates>
            {
                atRate,
                beRate,
                bgRate,
                //icRate,
                cyRate,
                czRate,
                dkRate,
                eeRate,
                fiRate,
                frRate,
                deRate,
                elRate,
                huRate,
                ieRate,
                itRate,
                lvRate,
                ltRate,
                luRate,
                mtRate,
                nlRate,
                plRate,
                ptRate,
                roRate,
                skRate,
                siRate,
                esRate,
                seRate,
                gbRate,
                noRate
            });


            var customRates = new List<CountryRates> {zzRate};


            // US
            var usRates = new List<CountryRates>();
            usRates.AddRange(new List<CountryRates>
            {
                alRate,
                arRate,
                akRate,
                caRate,
                usCoRate,
                usCtRate,
                usDcRate,
                usDlRate,
                usFlRate,
                usGaRate,
                usHaRate,
                usIdRate
            });
            usRates.AddRange(new List<CountryRates>
            {
                usIlRate,
                usInRate,
                usIoRate,
                usKaRate,
                usKtRate,
                usLoRate,
                usMaRate,
                usMdRate,
                usMiRate,
                usMnRate,
                usMrRate
            });
            usRates.AddRange(new List<CountryRates>
            {
                usMsRate,
                usMtRate,
                usNcRate,
                usNdRate,
                usNeRate,
                usNjRate,
                usNmRate,
                usNvRate,
                usNyRate,
                usOhRate,
                usOkRate
            });
            usRates.AddRange(new List<CountryRates>
            {
                usPnRate,
                usRoRate,
                usScRate,
                usSdRate,
                usTnRate,
                usTxRate,
                usUtRate,
                usVeRate,
                usViRate,
                usWaRate,
                usWsRate,
                usWvRate,
                usWyRate
            });


            // rest of the world

            var restOfTheWorldRates = new List<CountryRates>();
            restOfTheWorldRates.AddRange(new List<CountryRates>
            {
                wAlRate,
                wArmRate,
                wArRate,
                wAusRate,
                wBarRate,
                wBolRate,
                wBosRate,
                wBraRate,
                wChilRate,
                wChinRate,
                wColRate,
                wCroRate
            });
            restOfTheWorldRates.AddRange(new List<CountryRates>
            {
                wDomiRate,
                wEcuRate,
                wEgptRate,
                wElsalRate,
                wFijiRate,
                wGeorRate,
                wGuatRate,
                wGuyaRate,
                wIceRate,
                wIndoRate,
                wIndRate,
                wIsrRate
            });
            restOfTheWorldRates.AddRange(new List<CountryRates>
            {
                wJapRate,
                wJordRate,
                wKazaRate,
                wLebaRate,
                wMaceRate,
                wMalayRate,
                wMaurRate,
                wMexRate,
                wMoldRate,
                wMorocRate
            });
            restOfTheWorldRates.AddRange(new List<CountryRates>
            {
                wNewzRate,
                wNgnRate,
                wPakiRate,
                wPanaRate,
                wParaRate,
                wPeruRate,
                wPhilRate,
                wRussRate,
                wSaRate,
                wSerbRate,
                wSingRate,
                wSkRate,
                wSriRate,
                wSwRate
            });
            restOfTheWorldRates.AddRange(new List<CountryRates>
            {
                wThaiRate,
                wTntRate,
                wTurkRate,
                wUkrRate,
                wUruRate,
                wVeneRate,
                wVietRate
            });

            var canadaRates = new List<CountryRates>();
            canadaRates.AddRange(new List<CountryRates>
            {
                caAlRate,
                caBcRate,
                caMtRate,
                caNbRate,
                caNfRate,
                caNsRate,
                caOnRate,
                caPeiRate,
                caQuRate,
                caSaRate
            });

            euRates = euRates.OrderBy(rate => rate.LongName).ToList();
            customRates = customRates.OrderBy(rate => rate.LongName).ToList();
            usRates = usRates.OrderBy(rate => rate.LongName).ToList();
            restOfTheWorldRates = restOfTheWorldRates.OrderBy(rate => rate.LongName).ToList();
            canadaRates = canadaRates.OrderBy(rate => rate.LongName).ToList();

            var allRates = new List<CountryRates>();
            allRates.AddRange(euRates);
            allRates.AddRange(customRates);
            allRates.AddRange(usRates);
            allRates.AddRange(restOfTheWorldRates);
            allRates.AddRange(canadaRates);

            return await Task.FromResult(allRates);
        }
    }
}