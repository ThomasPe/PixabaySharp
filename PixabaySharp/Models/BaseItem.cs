using Newtonsoft.Json;

namespace PixabaySharp.Models
{
    /// <summary>
    /// Base class of an item returned by the api.
    /// </summary>
    public class BaseItem
    {
        /// <summary>
        /// A unique identifier for this item.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Total number of likes.
        /// </summary>
        [JsonProperty("likes")]
        public int Likes { get; set; }

        /// <summary>
        /// Total number of favorites.
        /// </summary>
        [JsonProperty("favorites")]
        public int Favorites { get; set; }

        /// <summary>
        /// String representation of tags.
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// Total number of views.
        /// </summary>
        [JsonProperty("views")]
        public int Views { get; set; }

        /// <summary>
        /// Total number of comments.
        /// </summary>
        [JsonProperty("comments")]
        public int Comments { get; set; }

        /// <summary>
        /// Total number of downloads.
        /// </summary>
        [JsonProperty("downloads")]
        public int Downloads { get; set; }

        /// <summary>
        /// Source page on Pixabay, which provides a download link for the original item 
        /// </summary>
        [JsonProperty("pageURL")]
        public string PageURL { get; set; }

        /// <summary>
        /// User ID of the contributor.
        /// </summary>
        [JsonProperty("user_id")]
        public int UserId { get; set; }

        /// <summary>
        /// User name of the contributor.
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Type of the item.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// User profile URL of the contributor.
        /// </summary>
        [JsonProperty("userImageURL")]
        public string UserImageURL { get; set; }
    }
}
