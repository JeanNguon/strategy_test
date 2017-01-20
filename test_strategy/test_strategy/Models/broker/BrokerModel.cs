using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_strategy.Models.broker
{
    public class BrokerModel : IConnector
    {
        public long placeOrder(long volume, string product)
        {
            if (volume < 1)
            {
                return 0L;
            }
            return volume;
        }

        public long closeOrder(long volume, string product)
        {
            if (volume > 0)
            {
                return 1;                
            }
            return -1;
        }
    }
}