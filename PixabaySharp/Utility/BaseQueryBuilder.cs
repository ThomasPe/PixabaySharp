using PixabaySharp.Enums;
using System;
using System.Text;

namespace PixabaySharp.Utility
{
    /// <summary>
    /// Base class to build a query against the Pixabay api.
    /// </summary>
    public class BaseQueryBuilder
    {
        /// <summary>
        /// A search term. 
        /// This value may not exceed 100 characters. 
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Language code of the language to be searched in.
        /// </summary>
        public Language? Language { get; set; }

        /// <summary>
        /// ID or a comma separated list of values for retrieving specific videos/images.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Filter results by category. 
        /// </summary>
        public Category? Category { get; set; }

        /// <summary>
        /// Minimum image/video width. 
        /// </summary>
        public int? MinWidth { get; set; }

        /// <summary>
        /// Minimum image/video height. 
        /// </summary>
        public int? MinHeight { get; set; }

        /// <summary>
        /// Select images/videos that have received an Editor's Choice award. 
        /// </summary>
        public bool? IsEditorsChoice { get; set; }

        /// <summary>
        /// A flag indicating that only images/videos suitable for all ages should be returned. 
        /// </summary>
        public bool? IsSafeSearch { get; set; }

        /// <summary>
        /// How the results should be ordered. 
        /// </summary>
        public Order? Order { get; set; }

        /// <summary>
        /// Returned search results are paginated. Use this parameter to select the page number. 
        /// </summary>
        public int? Page { get; set; }

        /// <summary>
        /// Determine the number of results per page.
        /// </summary>
        public int? PerPage { get; set; }


        /// <summary>
        /// Create url query string.
        /// </summary>
        /// <returns>query string</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();

            if (!String.IsNullOrEmpty(Query))
                sb.Append($"&q={HttpTools.UriEncode(Query)}");

            if (Language != null)
                sb.Append($"&lang={Language.ToString().ToLower()}");

            if (!String.IsNullOrEmpty(Id))
                sb.Append($"&id={Id}");

            if (Category != null)
                sb.Append($"&category={Category.ToString().ToLower()}");

            if (MinWidth != null && MinWidth != 0)
                sb.Append($"&min_width={MinWidth.ToString().ToLower()}");

            if (MinHeight != null && MinHeight != 0)
                sb.Append($"&min_height={MinHeight.ToString().ToLower()}");

            if (IsEditorsChoice != null)
                sb.Append($"&editors_choice={IsEditorsChoice.ToString().ToLower()}");

            if (IsSafeSearch != null)
                sb.Append($"&safesearch={IsSafeSearch.ToString().ToLower()}");

            if (Order != null)
                sb.Append($"&order={Order.ToString().ToLower()}");

            if (Page != null)
                sb.Append($"&page={Page}");

            if (PerPage != null)
                sb.Append($"&per_page={PerPage}");

            return sb.ToString();
        }
    }
}
