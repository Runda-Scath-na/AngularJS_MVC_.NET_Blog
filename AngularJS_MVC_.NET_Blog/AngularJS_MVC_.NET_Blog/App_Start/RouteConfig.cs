// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RouteConfig.cs" company="">
//   Copyright � 2015 
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace App.AngularJS_MVC_.NET_Blog {
    using System.Web.Routing;

    using App.AngularJS_MVC_.NET_Blog.Routing;

    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.Add("Default", new DefaultRoute());
        }
    }
}
