using Newtonsoft.Json;

namespace PixabaySharp.Models
{
    /// <summary>
    /// Reprensentation of an image.
    /// </summary>
    public class ImageItem : BaseItem
    {
        /// <summary>
        /// Hash ID of an image.
        /// </summary>
        [JsonProperty("id_hash")]
        public int IdHash { get; set; }

        /// <summary>
        /// Medium sized image with a maximum width or height of 640 px (webformatWidth x webformatHeight). 
        /// URL valid for 24 hours.
        /// </summary>
        [JsonProperty("webformatURL")]
        public string WebformatURL { get; set; }

        /// <summary>
        /// Width of the medium sized image.
        /// </summary>
        [JsonProperty("webformatWidth")]
        public int WebformatWidth { get; set; }

        /// <summary>
        /// Height of the medium sized image.
        /// </summary>
        [JsonProperty("webformatHeight")]
        public int WebformatHeight { get; set; }

        /// <summary>
        /// Low resolution images with a maximum width or height of 150 px.
        /// </summary>
        [JsonProperty("previewURL")]
        public string PreviewURL { get; set; }

        /// <summary>
        /// Width of the low sized image.
        /// </summary>
        [JsonProperty("previewWidth")]
        public int PreviewWidth { get; set; }

        /// <summary>
        /// Height of the medium sized image.
        /// </summary>
        [JsonProperty("previewHeight")]
        public int PreviewHeight { get; set; }

        /// <summary>
        /// High resolution image.
        /// </summary>
        [JsonProperty("imageURL")]
        public string ImageURL { get; set; }

        /// <summary>
        /// Width of the high sized image.
        /// </summary>
        [JsonProperty("imageWidth")]
        public int ImageWidth { get; set; }

        /// <summary>
        /// Height of the high sized image.
        /// </summary>
        [JsonProperty("imageHeight")]
        public int ImageHeight { get; set; }

        /// <summary>
        /// Large resolution image.
        /// </summary>
        [JsonProperty("largeImageURL")]
        public string LargeImageURL { get; set; }

        /// <summary>
        /// Full HD resolution image.
        /// </summary>
        [JsonProperty("fullHDURL")]
        public string FullHDImageURL { get; set; }
    }
}
