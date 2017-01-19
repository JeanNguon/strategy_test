using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_strategy.Models.brooker
{
    public class BrookerModel : IConnector
    {
        public long placeOrder(long volume, string product)
        {
            return volume;
        }

        public int closeOrder(long volume, string product)
        {
            return 1;
        }
    }
}