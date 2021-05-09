using Newtonsoft.Json;

namespace Todoist.QuickCapture.DTO
{
    public class LabelDTO
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }
    }
}
