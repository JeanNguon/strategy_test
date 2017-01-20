using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test_strategy.Models.broker
{
    [TestClass]
    public class BrokerModelTest
    {

        [TestMethod] // Success expected
        public void PlaceOrderTest1()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.placeOrder(1L, "rhum", true);
            Assert.AreEqual(1L, result);

        }
        [TestMethod] // Success expected
        public void PlaceOrderTest2()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.placeOrder(10L, "rhum", true);
            Assert.AreEqual(10L, result);
        }
        [TestMethod] // Fail expected
        public void PlaceOrderTest3()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.placeOrder(-10L, "rhum", true);
            Assert.AreEqual(-10L, result);
        }
        [TestMethod] // Success expected
        public void PlaceOrderTest4()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.placeOrder(-10L, "rhum", true);
            Assert.AreEqual(0L, result);
        }
        [TestMethod] // Fail expected
        public void PlaceOrderTest5()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.placeOrder(10L, "rhum", false);
            Assert.AreEqual(10L, result);
        }

        [TestMethod] // Success expected
        public void CloseOrderTest1()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.closeOrder(1L, "rhum", true);
            Assert.AreEqual(1L, result);

        }
        [TestMethod] // Success expected
        public void CloseOrderTest2()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.closeOrder(10L, "rhum", true);
            Assert.AreEqual(1, result);
        }
        [TestMethod] // Fail expected
        public void CloseOrderTest3()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.closeOrder(0L, "rhum", true);
            Assert.AreEqual(1, result);
        }
        [TestMethod] // Success expected
        public void CloseOrderTest4()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.closeOrder(0L, "rhum", true);
            Assert.AreEqual(0, result);
        }
        [TestMethod] // Success expected
        public void CloseOrderTest5()
        {
            BrokerModel Brooker = new BrokerModel();
            long result = Brooker.closeOrder(0L, "rhum", false);
            Assert.AreEqual(-1L, result);
        }
    }
}