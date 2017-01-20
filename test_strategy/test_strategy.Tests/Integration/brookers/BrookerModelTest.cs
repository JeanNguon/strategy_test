using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test_strategy.Models.brooker
{
    [TestClass]
    public class BrookerModelTest
    {

        [TestMethod]
        public void PlaceOrderTest1()
        {
            BrookerModel Brooker = new BrookerModel();
            long result = Brooker.placeOrder(1L, "rhum");
            Assert.AreEqual(1L, result);

        }
        [TestMethod]
        public void PlaceOrderTest2()
        {
            BrookerModel Brooker = new BrookerModel();
            long result = Brooker.placeOrder(10L, "rhum");
            Assert.AreEqual(10L, result);
        }
        [TestMethod]
        public void PlaceOrderTest3()
        {
            BrookerModel Brooker = new BrookerModel();
            long result = Brooker.placeOrder(-10L, "rhum");
            Assert.AreEqual(0L, result);
        }

        [TestMethod]
        public void CloseOrderTest1()
        {
            BrookerModel Brooker = new BrookerModel();
            long result = Brooker.closeOrder(1L, "rhum");
            Assert.AreEqual(1L, result);

        }
        [TestMethod]
        public void CloseOrderTest2()
        {
            BrookerModel Brooker = new BrookerModel();
            long result = Brooker.closeOrder(10L, "rhum");
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void CloseOrderTest3()
        {
            BrookerModel Brooker = new BrookerModel();
            long result = Brooker.closeOrder(0L, "rhum");
            Assert.AreEqual(-1, result);
        }
    }
}