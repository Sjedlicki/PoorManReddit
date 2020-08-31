using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PoorManReddit.Models
{

    public class RedditResponse
    {
        public string Kind { get; set; }
        public Data Data { get; set; }
    }

    public class Data
    {
        public string Modhash { get; set; }
        public int Dist { get; set; }
        public Child[] Children { get; set; }
        public string After { get; set; }
        public object Before { get; set; }
    }

    public class Child
    {
        public string Kind { get; set; }
        public Post Data { get; set; }
    }

    public class Post
    {
        [DisplayName("Title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [DisplayName("Thumbnail Height")]
        [JsonPropertyName("thumbnail_height")]
        public int ThumbnailHeight { get; set; }        
        
        [JsonPropertyName("thumbnail_width")]
        public int ThumbnailWidth { get; set; }
        public string Thumbnail { get; set; }
        public string Permalink { get; set; }
    }
}
