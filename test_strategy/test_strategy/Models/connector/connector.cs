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


        int IConnector.closeOrder(long volume, string product)
        {
           
            throw new NotImplementedException();
        }
        

        long IConnector.placeOrder(long volume, string product)
        {

            // return bool

           /*
            * param: volume
            */

            //return
            throw new NotImplementedException();
        }
    }
}