using Newtonsoft.Json;

namespace PixabaySharp.Models
{
    /// <summary>
    /// A set of differently sizes video streams
    /// </summary>
    public partial class Videos
    {
        /// <summary>
        /// "medium" typically has a dimension of 1280x720 and is available for all Pixabay videos. 
        /// </summary>
        [JsonProperty("medium")]
        public Video Medium { get; set; }

        /// <summary>
        /// "large" usually has a dimension of 1920x1080. 
        /// If a large video version is not available, an empty URL value and a size of zero is returned.
        /// </summary>
        [JsonProperty("large")]
        public Video Large { get; set; }

        /// <summary>
        /// "small" typically has a dimension of 960x540, older videos have a dimension of 640x360. This size is available for all videos. 
        /// </summary>
        [JsonProperty("small")]
        public Video Small { get; set; }

        /// <summary>
        /// "tiny" typically has a dimension of 640x360, older videos have a dimension of 480x270. This size is available for all videos. 
        /// </summary>
        [JsonProperty("tiny")]
        public Video Tiny { get; set; }
    }
}
