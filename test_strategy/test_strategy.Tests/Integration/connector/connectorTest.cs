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

            var connector = new Connector();
            var controller = new ConnectorController(connector);
            var result = controller.placeOrder() as ViewResult;
            if (result != null)
            {
                if (result.ViewData.Model != null)
                {
                    var test = (Connector)result.ViewData.Model;
                    if (test != null)
                    {
                        long closeOrder = test.closeOrder(1L, "test");
                        Assert.AreNotEqual("Laptop", closeOrder);
                    }else{
                        Assert.Fail();
                    }
                }
            }else {
                 
            }
        }


        public void IsBankBroker(Connector connector)
        {
            Assert.IsNotNull(connector.IConnector);
        }


        [TestMethod]
        public void closeOrder()
        {
            // Arrange
            ConnectorController controller = new ConnectorController();
        }
    }
}
