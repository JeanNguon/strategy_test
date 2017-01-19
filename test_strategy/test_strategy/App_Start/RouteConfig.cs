﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace test_strategy
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Connector", action = "placeOrder", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "close",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Connector", action = "closeOrder", id = UrlParameter.Optional }
            );
        }
    }
}
