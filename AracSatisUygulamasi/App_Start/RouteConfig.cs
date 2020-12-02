﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AracSatisUygulamasi
{
    public class RouteConfig
    {  
        public static void RegisterRoutes(RouteCollection routes)
        {

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Admin",
                url: "{controller}/{action}",
               defaults: new { controller = "Admin", action = "Index" }
           );

        }
    }
}

