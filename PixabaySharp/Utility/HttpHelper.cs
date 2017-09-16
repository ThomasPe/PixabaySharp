using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace PixabaySharp.Utility
{
    /// <summary>
    /// Helper class for making webrequests.
    /// </summary>
    public class HttpHelper
    {
        private readonly string _baseImageUri;
        private readonly string _baseVideoUri;
        private readonly string _apiKey;

        /// <summary>
        /// Create an instance of the HttpHelper for webrequests.
        /// </summary>
        /// <param name="apiKey">Pixabay api key</param>
        public HttpHelper(string apiKey)
        {
            _baseImageUri = "https://pixabay.com/api/";
            _baseVideoUri = "https://pixabay.com/api/videos/";
            _apiKey = apiKey;
        }

        /// <summary>
        /// Make an get webrequest to the Pixabay api and return the deserialized object.
        /// </summary>
        /// <typeparam name="TClass">Class which should be returned</typeparam>
        /// <param name="query">Query to search for</param>
        /// <param name="isImageSearch">Indicates if this search is an image search</param>
        /// <returns>Result of type TClass</returns>
        internal async Task<TClass> GetRequestAsync<TClass>(string query, bool isImageSearch = true)
            where TClass : class
        {
            HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.ExpectationFailed);

            using (var client = new HttpClient())
            {
                try
                {
                    var baseUri = isImageSearch ? _baseImageUri : _baseVideoUri;
                    response = await client.GetAsync($"{baseUri}?key={_apiKey}{query}").ConfigureAwait(false);
                    var responseString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                    if (response.IsSuccessStatusCode)
                        return JsonConvert.DeserializeObject<TClass>(responseString);

                    Debug.WriteLine(responseString);                    
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
