using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_strategy.Models.connector
{
    public class connector : IConnector
    {
        int IConnector.closeOrder()
        {
            throw new NotImplementedException();
        }

        void IConnector.placeOrder()
        {
            throw new NotImplementedException();
        }
    }
}