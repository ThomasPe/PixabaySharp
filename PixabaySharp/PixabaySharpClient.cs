using PixabaySharp.Models;
using PixabaySharp.Utility;
using System;
using System.Threading.Tasks;

namespace PixabaySharp
{
    public class PixabaySharpClient
    {
        private HttpHelper _httpHelper;

        public PixabaySharpClient(string apikey)
        {
            _httpHelper = new HttpHelper(apikey);
        }

        public async Task<Result> SearchAsync(string search)
        {
            var s = HttpTools.UriEncode(search);
            return await _httpHelper.GetRequestAsync<Result>($"&q={s}").ConfigureAwait(false);
        }

        public async Task<Result> QueryImagesAsync(ImageQueryBuilder qb)
        {
            var s = qb.ToString();
            return await _httpHelper.GetRequestAsync<Result>($"{s}").ConfigureAwait(false);
        }
    }
}
