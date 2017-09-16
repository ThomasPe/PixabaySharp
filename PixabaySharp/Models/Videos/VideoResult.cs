using Newtonsoft.Json;
using System.Collections.Generic;

namespace PixabaySharp.Models
{
    /// <summary>
    /// Class which represents a video.
    /// </summary>
    public class VideoResult : BaseResult
    {
        /// <summary>
        /// List of videos.
        /// </summary>
        [JsonProperty("hits")]
        public IList<VideoItem> Videos { get; set; }
    }
}
