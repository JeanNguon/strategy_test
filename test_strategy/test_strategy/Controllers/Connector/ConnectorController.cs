using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_strategy.Models.connector;

namespace test_strategy.Controllers
{
    public class ConnectorController : Controller
    {

        private Connector connector;

        public ActionResult placeOrder()
        {
            ViewBag.Message = "placeOrder";
            return View();
        }

        public ActionResult closeOrder()
        {
            ViewBag.Message = "closeOrder";

            return View();
        }

    }
}