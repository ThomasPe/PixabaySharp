using Newtonsoft.Json;
using System.Collections.Generic;

namespace PixabaySharp.Models
{
    /// <summary>
    /// Class which represents an image.
    /// </summary>
    public class ImageResult : BaseResult
    {
        /// <summary>
        /// List of images.
        /// </summary>
        [JsonProperty("hits")]
        public IList<ImageItem> Images { get; set; }
    }
}
