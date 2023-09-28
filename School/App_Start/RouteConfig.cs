﻿using System.Web.Mvc;
using System.Web.Routing;

namespace School
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }


            );


            routes.MapRoute(
              name: "StudentDashboard",
              url: "Dashboards/StudentDashboard",
              defaults: new { controller = "Student", action = "StudentDashboard" }
          );

        }


    }
}
