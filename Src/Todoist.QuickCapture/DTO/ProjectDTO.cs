using Newtonsoft.Json;

namespace Todoist.QuickCapture.DTO
{
    public class ProjectDTO
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("shared")]
        public bool Shared { get; set; }

        [JsonProperty("sync_id")]
        public int SyncId { get; set; }

        [JsonProperty("favorite")]
        public bool Favorite { get; set; }

        [JsonProperty("inbox_project")]
        public bool InboxProject { get; set; }
    }
}
