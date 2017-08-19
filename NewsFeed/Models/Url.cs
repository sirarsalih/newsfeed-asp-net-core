using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NewsFeed.Models
{
    public class Url
    {
        [JsonProperty("url")]
        public string UrlString { get; set; }
    }
}
