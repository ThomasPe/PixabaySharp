using Newtonsoft.Json;

namespace PixabaySharp.Models
{
    /// <summary>
    /// Reprensentation of a video.
    /// </summary>
    public class VideoItem : BaseItem
    {
        /// <summary>
        /// A set of differently sizes video streams.
        /// </summary>
        [JsonProperty("videos")]
        public Videos Videos { get; set; }
    }
}
