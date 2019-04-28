using Xunit;
using LadaStore.Controllers;
using System.Web.Mvc;
using LadaStore.Data;
using System;

namespace LadaStoreTest.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void TestPrivacyView()
        {
            HomeController controller = new HomeController(null);
            ViewResult result = controller.Privacy() as ViewResult;
            Assert.Null(result);
        }
    }
}