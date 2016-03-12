﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.Script.Services;

namespace Farmarket
{
    public class RouteConfig
    {
        public static void Register(HttpConfiguration config)
        {
           config.Routes.MapHttpRoute(
           name: "DefaultApi",
           routeTemplate: "api/{controller}/{id}",
           defaults: new { id = RouteParameter.Optional }
           );
           config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

        }
    }
}