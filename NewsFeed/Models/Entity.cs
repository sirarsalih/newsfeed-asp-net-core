﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NewsFeed.Models
{
    public class Entity
    {
        [JsonProperty("urls")]
        public List<Url> Urls { get; set; }

        [JsonProperty("media")]
        public List<Media> Media { get; set; }
    }
}
