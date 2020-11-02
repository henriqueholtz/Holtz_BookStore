using Holtz_BookStore.API.RouteConstraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing;
using System.Web.Routing;

namespace Holtz_BookStore.API
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //var constrainsResolver = new DefaultInlineConstraintResolver(); //Personal Route 
            //constrainsResolver.ConstraintMap.Add("values", typeof(ValuesConstraint)); //RouteConstraints/ValuesConstraint

            routes.MapMvcAttributeRoutes(/*constrainsResolver*/);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
