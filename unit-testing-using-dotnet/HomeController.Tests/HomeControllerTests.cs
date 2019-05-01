using Xunit;
using LadaStore.Controllers.HomeController;
using System.Web.Mvc;
using LadaStore.Data;
using System;

namespace HomeController.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void TestPrivacyView()
        {
            HomeController controller = new HomeController();
            ViewResult result = controller.Privacy() as ViewResult;
            Assert.Equal("Privacy", result);
        }
    }
}