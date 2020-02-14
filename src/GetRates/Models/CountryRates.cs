using System.Collections.Generic;

namespace Models
{
    
    public class CountryRates
    {
        public string Country { get; set; }

        public string LongName { get; set; }


        public int StdRate { get; set; }


        public bool UseForValidation { get; set; }


        public int Section { get; set; }


        public List<double> Rates { get; set; }

    }
}