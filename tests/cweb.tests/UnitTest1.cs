using Microsoft.VisualStudio.TestTools.UnitTesting;
using cweb.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace cweb.tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void AboutPageTest()
        {
           var homeController = new HomeController();
           var result = homeController.About();
        }
    }
}
