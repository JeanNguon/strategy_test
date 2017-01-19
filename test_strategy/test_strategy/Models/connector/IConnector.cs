using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_strategy.Models
{
    interface IConnector
    {
        void placeOrder(long volume, String product);
        Int32 closeOrder(long volume, String product);
    }
}
