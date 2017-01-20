using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test_strategy.Models.connector;
using System.Web.UI.WebControls;
using test_strategy.Models;

namespace test_strategy.Controllers
{
    public class ConnectorController : Controller
    {
        private IConnector connector;
        public ConnectorController()
        {

        }
        public ConnectorController(IConnector connector) {
            this.connector = connector;
        }


      
        public ActionResult placeOrder()
        {
            ViewData["message"] = "Hello World!";
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