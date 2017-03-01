using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SampleProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();


            routes.MapRoute(
                         name: "API Default",
                         url: "api/{controller}/{action}/{id}"
                         );
            routes.MapRoute(
                             name: "DefaultApiMvc",
                             url: "api/{controller}/{action}"
                            );
            routes.MapRoute(
                            name: "DefaultApiMvcWithID",
                            url: "api/{controller}/{Id}",
                            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                           );
         
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Products", action = "Products", id = UrlParameter.Optional }

            );

  
        }
    }
}
