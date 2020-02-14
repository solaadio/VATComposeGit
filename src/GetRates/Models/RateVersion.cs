using Newtonsoft.Json;

namespace Models
{
  
    public class RateVersion
    {
        [JsonProperty("Version")]
        public double Version { get; set; }

        [JsonProperty("VersionDate")]
        public string VersionDate { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

    }
}