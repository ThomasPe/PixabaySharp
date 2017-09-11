using PixabaySharp.Models;
using PixabaySharp.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web;

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
            var s = HttpUtility.UrlEncode(search);
            return await _httpHelper.GetRequest<Result>($"&q={s}").ConfigureAwait(false);
        }

        public async Task<Result> QueryImages(ImageQueryBuilder qb)
        {
            var s = qb.ToString();
            return await _httpHelper.GetRequest<Result>($"{s}").ConfigureAwait(false);
        }
    }
}
