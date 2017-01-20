using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_strategy.Models.connector
{
    public class Connector : IConnector
    {
        private IConnector connector;

        public IConnector IConnector
        {
            get
            {
                return this.connector;
            }

            set
            {
                this.connector = value;
            }
        }

        public Connector()
        {
            
        }

        public long closeOrder(long volume, string product)
        {
            return this.IConnector.closeOrder(volume, product);
        }

        
        public long placeOrder(long volume, string product)
        {
            return this.IConnector.placeOrder(volume, product);
        }
    }
}