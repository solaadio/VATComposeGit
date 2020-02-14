using Newtonsoft.Json;

namespace Models
{

    public class ResponseObject
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("IsValid")]
        public bool IsValid { get; set; }

        [JsonProperty("ServerResponse")]
        public string ServerResponse { get; set; }
    }
}