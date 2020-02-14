using Newtonsoft.Json;

namespace Models
{
    public class WhatsNewResult
    {
        [JsonProperty("NotificationId")]
        public int NotificationId { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Body")]
        public string Body { get; set; }

        [JsonProperty("ButtonTitle")]
        public string ButtonTitle { get; set; }
    }
}