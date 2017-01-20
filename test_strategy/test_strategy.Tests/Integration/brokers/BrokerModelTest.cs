using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test_strategy.Models.broker
{
    [TestClass]
    public class BrokerModelTest
    {

        [TestMethod]
        public void PlaceOrderTest1()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.placeOrder(1L, "rhum");
            Assert.AreEqual(1L, result);

        }
        [TestMethod]
        public void PlaceOrderTest2()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.placeOrder(10L, "rhum");
            Assert.AreEqual(10L, result);
        }
        [TestMethod]
        public void PlaceOrderTest3()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.placeOrder(-10L, "rhum");
            Assert.AreEqual(0L, result);
        }

        [TestMethod]
        public void CloseOrderTest1()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.closeOrder(1L, "rhum");
            Assert.AreEqual(1L, result);

        }
        [TestMethod]
        public void CloseOrderTest2()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.closeOrder(10L, "rhum");
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void CloseOrderTest3()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.closeOrder(0L, "rhum");
            Assert.AreEqual(-1, result);
        }
    }
}