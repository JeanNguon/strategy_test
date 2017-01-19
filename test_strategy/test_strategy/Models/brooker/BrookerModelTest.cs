using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_strategy.Models.brooker
{
    public class BrookerModelTest
    {
        BrookerModel Brooker = new BrookerModel();

        public bool PlaceOrderTest1()
        {
            long result = Brooker.placeOrder(1L, "rhum");
            if (result == 1L)
            {
                return true; 
            }
            return false;

        }
        public bool PlaceOrderTest2()
        {
            long result = Brooker.placeOrder(1L, "rhum");
            if (result == 1L)
            {
                return true;
            }
            return false;
        }
        public bool PlaceOrderTest3()
        {
            long result = Brooker.placeOrder(1L, "rhum");
            if (result == 1L)
            {
                return true;
            }
            return false;
        }

        public bool CloseOrderTest1()
        {
            long result = Brooker.closeOrder(1L, "rhum");
            if (result == 1L)
            {
                return true;
            }
            return false;
        }
        public bool CloseOrderTest2()
        {
            long result = Brooker.closeOrder(1L, "rhum");
            if (result == 1L)
            {
                return true;
            }
            return false;
        }
        public bool CloseOrderTest3()
        {
            long result = Brooker.closeOrder(1L, "rhum");
            if (result == 1L)
            {
                return true;
            }
            return false;
        }
    }
}