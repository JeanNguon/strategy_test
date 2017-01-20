using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_strategy.Models.connector
{
    public class Connector : IConnector
    {

       public Connector()
        {
            
        }

        public long closeOrder(long volume, string product)
        {
            return GetVolume(volume);
        }
           
        private static long GetVolume(long volume)
        {
            return volume;
        }
        
        public long placeOrder(long volume, string product)
        {
            return GetVolume(volume);
        }
    }
}