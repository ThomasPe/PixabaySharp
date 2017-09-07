using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace PixabaySharp.Tests
{
    [TestClass]
    public class ClientTests
    {
        [TestMethod]
        public async Task BasicTestAsync()
        {
            var client = new PixabaySharpClient(Utility.ApiCredentials.ApiKey);
            var images = await client.Search("dog");
            Assert.IsNotNull(images);
        }
    }
}
