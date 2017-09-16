using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using PixabaySharp.Utility;

namespace PixabaySharp.Tests
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public async Task BasicImageTest()
        {
            var client = new PixabaySharpClient(Utility.ApiCredentials.ApiKey);
            var images = await client.SearchImagesAsync("dog");
            Assert.IsNotNull(images);
        }

        [TestMethod]
        public async Task BasicVideoTest()
        {
            var client = new PixabaySharpClient(Utility.ApiCredentials.ApiKey);
            var videos = await client.SearchVideosAsync("dog");
            Assert.IsNotNull(videos);
        }

        [TestMethod]
        public async Task QueryImagesTest()
        {
            var client = new PixabaySharpClient(Utility.ApiCredentials.ApiKey);
            var result = await client.QueryImagesAsync(new ImageQueryBuilder()
            {
                Query = "Dog",
                PerPage = 5
            });
            Assert.AreEqual(result.Images.Count, 5);

            result = await client.QueryImagesAsync(new ImageQueryBuilder()
            {
                Query = "Dog",
                PerPage = 15
            });
            Assert.AreEqual(result.Images.Count, 15);
        }

        [TestMethod]
        public async Task QueryVideoTest()
        {
            var client = new PixabaySharpClient(Utility.ApiCredentials.ApiKey);
            var result = await client.QueryVideosAsync(new VideoQueryBuilder()
            {
                Query = "Dog",
                PerPage = 5
            });
            Assert.AreEqual(result.Videos.Count, 5);

            result = await client.QueryVideosAsync(new VideoQueryBuilder()
            {
                Query = "Dog",
                PerPage = 15
            });
            Assert.AreEqual(result.Videos.Count, 15);
        }
    }
}
