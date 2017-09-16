using Newtonsoft.Json;

namespace PixabaySharp.Models
{
    /// <summary>
    /// Reprensentation of an video element.
    /// </summary>
    public partial class Video
    {
        /// <summary>
        /// Size of the video.
        /// </summary>
        [JsonProperty("size")]
        public long Size { get; set; }

        /// <summary>
        /// Height of the video.
        /// </summary>
        [JsonProperty("height")]
        public long Height { get; set; }

        /// <summary>
        /// Url of the video.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Width of the video.
        /// </summary>
        [JsonProperty("width")]
        public long Width { get; set; }
    }
}
