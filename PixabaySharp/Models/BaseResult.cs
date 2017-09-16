using Newtonsoft.Json;

namespace PixabaySharp.Models
{
    /// <summary>
    /// Base class for an api result.
    /// </summary>
    public class BaseResult
    {
        /// <summary>
        /// The number of videos accessible through the API.
        /// By default, the API is limited to return a maximum of 500 videos per query.
        /// </summary>
        [JsonProperty("totalHits")]
        public int TotalHits { get; set; }

        /// <summary>
        /// The total number of hits.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
