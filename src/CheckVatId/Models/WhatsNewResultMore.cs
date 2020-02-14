using Newtonsoft.Json;

namespace Models
{
    public class WhatsNewResultMore : WhatsNewResult
    {
        [JsonProperty("VersionId")]
        public string VersionId { get; set; }

    }
}