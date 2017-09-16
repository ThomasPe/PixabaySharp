using PixabaySharp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace PixabaySharp.Utility
{
    /// <summary>
    /// Class to generate a query for videos.
    /// </summary>
    public class VideoQueryBuilder : BaseQueryBuilder
    {
        /// <summary>
        /// Filter results by video type. 
        /// </summary>
        public VideoType? VideoType { get; set; }


        /// <summary>
        /// Create url query string.
        /// </summary>
        /// <returns>query string</returns>
        public override string ToString()
        {
            var baseQuery = base.ToString();

            var sb = new StringBuilder(baseQuery);

            if (VideoType != null)
                sb.Append($"&video_type={VideoType.ToString().ToLower()}");

            return sb.ToString();
        }
    }
}
