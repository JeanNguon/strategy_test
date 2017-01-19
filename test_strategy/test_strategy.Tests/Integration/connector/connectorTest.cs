using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using test_strategy;
using test_strategy.Models.connector;
using test_strategy.Models;
using test_strategy.Controllers;

namespace test_strategy.Tests.Controllers
{
    [TestClass]
    public class ConnectorTest
    {
        [TestMethod]
        public void TestcloseOrderView()
        {
            var controller = new ConnectorController();
            var result = controller.closeOrder() as ViewResult;
            var connector = (Connector)result.ViewData.Model;
            long closeOrder = connector.closeOrder(1L, "test");
            Assert.AreEqual("Laptop", closeOrder);

        }


        [TestMethod]
        public void closeOrder()
        {

            // Arrange
            ConnectorController controller = new ConnectorController();

            
        }
    }
}
