using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace PixabaySharp.Models
{
    public class Image
    {
        [JsonProperty("previewHeight")]
        public int PreviewHeight { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("favorites")]
        public int Favorites { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("webformatHeight")]
        public int WebformatHeight { get; set; }

        [JsonProperty("views")]
        public int Views { get; set; }

        [JsonProperty("webformatWidth")]
        public int WebformatWidth { get; set; }

        [JsonProperty("previewWidth")]
        public int PreviewWidth { get; set; }

        [JsonProperty("comments")]
        public int Comments { get; set; }

        [JsonProperty("downloads")]
        public int Downloads { get; set; }

        [JsonProperty("pageURL")]
        public string PageURL { get; set; }

        [JsonProperty("previewURL")]
        public string PreviewURL { get; set; }

        [JsonProperty("webformatURL")]
        public string WebformatURL { get; set; }

        [JsonProperty("imageWidth")]
        public int ImageWidth { get; set; }

        [JsonProperty("user_id")]
        public int UserId { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("userImageURL")]
        public string UserImageURL { get; set; }

        [JsonProperty("imageHeight")]
        public int ImageHeight { get; set; }
    }
}
