using Newtonsoft.Json;
using System.Collections.Generic;

namespace PixabaySharp.Models
{
    public class Result
    {
        [JsonProperty("totalHits")]
        public int TotalHits { get; set; }

        [JsonProperty("hits")]
        public IList<Image> Images { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
