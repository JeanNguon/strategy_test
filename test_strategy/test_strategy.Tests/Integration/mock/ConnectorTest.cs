using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using test_strategy.Controllers;
using test_strategy.Models.connector;
using FluentAssertions;

namespace test_strategy.Models.connector
{
    [TestClass]
    public class ConnectorTests
    {
        private Mock<IConnector> mock;
        private MockRepository mockRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.mock.VerifyAll();
            this.mockRepository.VerifyAll();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Connector connector = this.CreateConnector();
        }

        private Connector CreateConnector()
        {
            return new Connector();
        }

        private void TestPlaceOrder()
        {
            this.mock = new Mock<IConnector>();
            this.mock.Setup(x => x.placeOrder(1L, "test")).Returns(1L);
            ConnectorController controller = new ConnectorController(this.mock.Object);
            controller.placeOrder();
            controller.Should().NotBeNull();
        }
    }
}
