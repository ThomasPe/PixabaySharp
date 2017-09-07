using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PixabaySharp.Utility
{
    class HttpHelper
    {
        private string _baseUri;
        private string _apiKey;

        public HttpHelper(string apiKey)
        {
            _baseUri = "https://pixabay.com/api/";
            _apiKey = apiKey;
        }

        internal async Task<TClass> GetRequest<TClass>(string query)
            where TClass : class
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.ExpectationFailed);

            using (var client = new HttpClient())
            {
                try
                {
                    response = await client.GetAsync($"{_baseUri}?key={_apiKey}{query}").ConfigureAwait(false);
                    var responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    if (response.IsSuccessStatusCode)
                    {
                        return JsonConvert.DeserializeObject<TClass>(responseString);
                    }
                    else
                    {
                        Debug.WriteLine(responseString);
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("exception thrown: " + ex.Message);
                }
            }
            return default(TClass);
        }
    }
}
