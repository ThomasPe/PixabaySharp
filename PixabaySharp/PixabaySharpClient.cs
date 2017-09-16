using PixabaySharp.Models;
using PixabaySharp.Utility;
using System.Threading.Tasks;

namespace PixabaySharp
{
    /// <summary>
    /// Class to access the Pixabay api.
    /// </summary>
    public class PixabaySharpClient
    {
        private readonly HttpHelper _httpHelper;

        /// <summary>
        /// Creates an instance with a provided Pixabay api key.
        /// </summary>
        /// <param name="apikey">Pixabay api key to access the api</param>
        public PixabaySharpClient(string apikey)
        {
            _httpHelper = new HttpHelper(apikey);
        }

        /// <summary>
        /// Simple search for images for a provided query.
        /// </summary>
        /// <param name="search">Query to search for</param>
        /// <returns><seealso cref="ImageResult"/></returns>
        public async Task<ImageResult> SearchImagesAsync(string search)
        {
            var s = HttpTools.UriEncode(search);
            return await _httpHelper.GetRequestAsync<ImageResult>($"&q={s}").ConfigureAwait(false);
        }

        /// <summary>
        /// Simple search for videos for a provided query.
        /// </summary>
        /// <param name="search">Query to search for</param>
        /// <returns><seealso cref="VideoResult"/></returns>
        public async Task<VideoResult> SearchVideosAsync(string search)
        {
            var s = HttpTools.UriEncode(search);
            return await _httpHelper.GetRequestAsync<VideoResult>($"&q={s}", false).ConfigureAwait(false);
        }


        /// <summary>
        /// Complex search for images.
        /// </summary>
        /// <param name="qb"><see cref="ImageQueryBuilder"/> instance to search for</param>
        /// <returns><seealso cref="ImageResult"/></returns>
        public async Task<ImageResult> QueryImagesAsync(ImageQueryBuilder qb)
        {
            var s = qb.ToString();
            return await _httpHelper.GetRequestAsync<ImageResult>($"{s}").ConfigureAwait(false);
        }

        /// <summary>
        /// Complex search for videos.
        /// </summary>
        /// <param name="qb"><see cref="VideoQueryBuilder"/> instance to search for</param>
        /// <returns><seealso cref="VideoResult"/></returns>
        public async Task<VideoResult> QueryVideosAsync(VideoQueryBuilder qb)
        {
            var s = qb.ToString();
            return await _httpHelper.GetRequestAsync<VideoResult>($"{s}", false).ConfigureAwait(false);
        }
    }
}
