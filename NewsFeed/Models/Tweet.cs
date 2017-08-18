using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NewsFeed.Models
{
    public class Tweet
    {
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("id_str")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }
}
