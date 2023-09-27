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
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }


            );

            routes.MapRoute(
    name: "InsertTestStudent",
    url: "Test/InsertTestStudent", // Define your desired URL path
    defaults: new { controller = "Home", action = "InsertTestStudent" }
);
        }


    }
}
