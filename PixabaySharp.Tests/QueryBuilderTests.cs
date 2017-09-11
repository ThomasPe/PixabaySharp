using Microsoft.VisualStudio.TestTools.UnitTesting;
using PixabaySharp.Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixabaySharp.Tests
{
    [TestClass]
    public class QueryBuilderTests
    {
        [TestMethod]
        public void ImageQueryBuilderTest()
        {
            var qb = new ImageQueryBuilder();
            qb.Id = "123";
            Assert.AreEqual("&id=123", qb.ToString());

            qb.Language = Lang.DE;
            Assert.AreEqual("&lang=de&id=123", qb.ToString());

            qb.Query = "yellow flower";
            Assert.AreEqual("&q=yellow+flower&lang=de&id=123", qb.ToString());

            qb.ResponseGroup = ResponseGroup.HighResolution;
            Assert.AreEqual("&q=yellow+flower&lang=de&id=123&response_group=high_resolution", qb.ToString());
            qb.ResponseGroup = ResponseGroup.ImageDetails;
            Assert.AreEqual("&q=yellow+flower&lang=de&id=123&response_group=image_details", qb.ToString());

            foreach (ImageType type in Enum.GetValues(typeof(ImageType)))
            {
                qb.ImageType = type;
                Assert.AreEqual($"&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type={type.ToString().ToLower()}", qb.ToString());
            }
            qb.ImageType = ImageType.All;
            Assert.AreEqual("&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=all", qb.ToString());
            qb.ImageType = ImageType.Illustration;
            Assert.AreEqual("&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=illustration", qb.ToString());
            qb.ImageType = ImageType.Photo;
            Assert.AreEqual("&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=photo", qb.ToString());
            qb.ImageType = ImageType.Vector;
            Assert.AreEqual("&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=vector", qb.ToString());

            foreach (Orientation orientation in Enum.GetValues(typeof(Orientation)))
            {
                qb.Orientation = orientation;
                Assert.AreEqual($"&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=vector&orientation={orientation.ToString().ToLower()}", qb.ToString());
            }
            qb.Orientation = Orientation.Vertical;
            Assert.AreEqual($"&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=vector&orientation=vertical", qb.ToString());

            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                qb.Category = category;
                Assert.AreEqual($"&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=vector&orientation=vertical&category={category.ToString().ToLower()}", qb.ToString());
            }
            qb.Category = Category.Business;
            Assert.AreEqual($"&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=vector&orientation=vertical&category=business", qb.ToString());

            qb.MinWidth = 100;
            Assert.AreEqual($"&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=vector&orientation=vertical&category=business&min_width=100", qb.ToString());

            qb.MinHeight = 100;
            Assert.AreEqual($"&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=vector&orientation=vertical&category=business&min_width=100&min_height=100", qb.ToString());

            qb.IsEditorsChoice = true;
            Assert.AreEqual($"&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=vector&orientation=vertical&category=business&min_width=100&min_height=100&editors_choice=true", qb.ToString());

            qb.IsEditorsChoice = true;
            Assert.AreEqual($"&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=vector&orientation=vertical&category=business&min_width=100&min_height=100&editors_choice=true", qb.ToString());

            qb.IsSafeSearch = true;
            Assert.AreEqual($"&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=vector&orientation=vertical&category=business&min_width=100&min_height=100&editors_choice=true&safesearch=true", qb.ToString());

            qb.Order = Order.Latest;
            Assert.AreEqual($"&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=vector&orientation=vertical&category=business&min_width=100&min_height=100&editors_choice=true&safesearch=true&order=latest", qb.ToString());
            qb.Order = Order.Popular;
            Assert.AreEqual($"&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=vector&orientation=vertical&category=business&min_width=100&min_height=100&editors_choice=true&safesearch=true&order=popular", qb.ToString());

            qb.Page = 2;
            Assert.AreEqual($"&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=vector&orientation=vertical&category=business&min_width=100&min_height=100&editors_choice=true&safesearch=true&order=popular&page=2", qb.ToString());

            qb.PerPage = 5;
            Assert.AreEqual($"&q=yellow+flower&lang=de&id=123&response_group=image_details&image_type=vector&orientation=vertical&category=business&min_width=100&min_height=100&editors_choice=true&safesearch=true&order=popular&page=2&per_page=5", qb.ToString());
        }
    }
}
