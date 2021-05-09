using Newtonsoft.Json;
using System;

namespace Todoist.QuickCapture.DTO
{
    public class TaskDTO
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }

        [JsonProperty("due")]
        public DueDTO Due { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("priority")]
        public int Priority { get; set; }

        [JsonProperty("project_id")]
        public long ProjectId { get; set; }

        [JsonProperty("section_id")]
        public long SectionId { get; set; }

        [JsonProperty("parent_id")]
        public long ParentId { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }
    }

    public class DueDTO
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("datetime")]
        public DateTime ScheduledOn { get; set; }

        [JsonProperty("string")]
        public string ScheduledOnString { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}
