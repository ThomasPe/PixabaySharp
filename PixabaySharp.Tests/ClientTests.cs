using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using PixabaySharp.Utility;

namespace PixabaySharp.Tests
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public async Task BasicTest()
        {
            var client = new PixabaySharpClient(Utility.ApiCredentials.ApiKey);
            var images = await client.SearchAsync("dog");
            Assert.IsNotNull(images);
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

            result = await client.QueryImages(new ImageQueryBuilder()
            {
                Query = "Dog",
                PerPage = 15
            });
            Assert.AreEqual(result.Images.Count, 15);
        }
    }
}
