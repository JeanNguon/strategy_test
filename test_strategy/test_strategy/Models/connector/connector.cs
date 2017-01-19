using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_strategy.Models.connector
{
    public class connector : IConnector
    {


        int IConnector.closeOrder(long volume, string product)
        {
            throw new NotImplementedException();
        }
        

        void IConnector.placeOrder(long volume, string product)
        {
            throw new NotImplementedException();
        }
    }
}