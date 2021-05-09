using Newtonsoft.Json;

namespace Todoist.QuickCapture.DTO
{
    public class NewTaskDTO
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("project_id")]
        public long Project { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("label_ids")]
        public long[] Labels { get; set; }

        [JsonProperty("due_string")]
        public string DueString { get; set; }
    }
}
