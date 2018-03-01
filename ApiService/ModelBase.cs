using Newtonsoft.Json;

namespace OutlookToDesktop.ApiService
{
    public class ModelBase
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
