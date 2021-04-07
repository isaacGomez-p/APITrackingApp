using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI_DT_3k.App_Start;

namespace WebAPI_DT_3k
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuración y servicios de API web
            //Anular Salida XML
            // config.Formatters.Remove(config.Formatters.XmlFormatter);
            // Rutas de API web

            //Configuración Cors
            config.EnableCors(new AccessPolicyCors());

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
