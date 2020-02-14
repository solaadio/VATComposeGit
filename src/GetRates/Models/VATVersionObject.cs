using Newtonsoft.Json;

namespace Models
{
    // ReSharper disable once InconsistentNaming
    public class VATVersionObject
    {
        [JsonProperty("VersionId")]
        public double VersionId { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

    }
}