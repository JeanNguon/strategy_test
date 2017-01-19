using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using test_strategy;
using test_strategy.Controllers;

namespace test_strategy.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void placeOrder()
        {
            // Arrange
            ConnectorController controller = new ConnectorController();

            // Act
            ViewResult result = controller.placeOrder() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void closeOrder()
        {
            // Arrange
            ConnectorController controller = new ConnectorController();

            // Act
            ViewResult result = controller.closeOrder() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
