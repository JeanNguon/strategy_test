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
        public void TestPlaceOrderView()
        {
            var controller = new ConnectorController();
            var result = controller.placeOrder() as ViewResult;
            var connector = (Connector)result.ViewData.Model;
            if (connector != null){
                long closeOrder = connector.closeOrder(1L, "test");
                Assert.AreNotEqual("Laptop", closeOrder);
            }
            else{
                Assert.Fail();
            }
        }


        [TestMethod]
        public void closeOrder()
        {

            // Arrange
            ConnectorController controller = new ConnectorController();

            
        }
    }
}
