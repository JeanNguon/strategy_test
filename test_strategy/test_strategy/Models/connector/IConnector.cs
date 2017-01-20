using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_strategy.Models
{
    public interface IConnector
    {
        long placeOrder(long volume, String product, bool isConnected);
        long closeOrder(long volume, String product, bool isConnected);
    }
}
