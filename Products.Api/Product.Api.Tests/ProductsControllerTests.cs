using Microsoft.VisualStudio.TestTools.UnitTesting;
using Products.Api.Controllers;
using System.Linq;

namespace Product.Api.Tests
{
    [TestClass]
    public class ProductsControllerTests
    {
        [TestMethod]
        public void Should_Return_2_Products()
        {
            var prodController = new ProductsController();
            var products = prodController.Get();
            Assert.IsTrue(products.Count() == 3);
        }
    }
}
