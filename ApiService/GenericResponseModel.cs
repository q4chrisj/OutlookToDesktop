using Newtonsoft.Json;

namespace OutlookToDesktop.ApiService
{
    public class GenericResponseModel
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}