using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_strategy.Models
{
    interface IConnector
    {
        void placeOrder();
        Int32 closeOrder();
    }
}
