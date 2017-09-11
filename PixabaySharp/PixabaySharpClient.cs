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

        public async Task<Result> Search(string search)
        {
            var s = HttpTools.UriEncode(search);
            return await _httpHelper.GetRequest<Result>($"&q={s}").ConfigureAwait(false);
        }

        public async Task<Result> QueryImages(ImageQueryBuilder qb)
        {
            var s = qb.ToString();
            return await _httpHelper.GetRequest<Result>($"{s}").ConfigureAwait(false);
        }
    }
}
