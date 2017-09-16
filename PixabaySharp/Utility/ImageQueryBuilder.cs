using PixabaySharp.Enums;
using System;
using System.Text;

namespace PixabaySharp.Utility
{
    /// <summary>
    /// Class to generate a query for images.
    /// </summary>
    public class ImageQueryBuilder : BaseQueryBuilder
    {
        /// <summary>
        /// Choose between retrieving high resolution images and image details.
        /// </summary>
        public ResponseGroup? ResponseGroup { get; set; }

        /// <summary>
        /// Filter results by image type. 
        /// </summary>
        public ImageType? ImageType{ get; set; }

        /// <summary>
        /// Whether an image is wider than it is tall, or taller than it is wide. 
        /// </summary>
        public Orientation? Orientation { get; set; }


        /// <summary>
        /// Create url query string.
        /// </summary>
        /// <returns>query string</returns>
        public override string ToString()
        {
            var baseQuery = base.ToString();

            var sb = new StringBuilder(baseQuery);

            if (ResponseGroup != null)
            {
                if(ResponseGroup == Enums.ResponseGroup.HighResolution)
                    sb.Append($"&response_group=high_resolution");
                else
                    sb.Append($"&response_group=image_details");
            }
            if (ImageType != null)
            {
                sb.Append($"&image_type={ImageType.ToString().ToLower()}");
            }
            if (Orientation != null)
            {
                sb.Append($"&orientation={Orientation.ToString().ToLower()}");
            }

            return sb.ToString();
        }
    }
}
