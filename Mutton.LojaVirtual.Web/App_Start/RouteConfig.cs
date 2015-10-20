using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mutton.LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //rota /
            routes.MapRoute(
               name: null,
               url: "",
               defaults: new {controller = "Vitrine", action = "ListaProdutos", categoria = (string)null , pagina = 1 }
           );

            //rota /Paginax
            routes.MapRoute(
                 null,
                 "Pagina{pagina}",
                 new{controller = "Vitrine",action = "ListaProdutos",categoria = (string)null},new { pagina= @"\d+" }
            );

            //rota /Categoria
            routes.MapRoute(
                name: null,
                url: "{categoria}",
                defaults: new { controller = "Vitrine", action = "ListaProdutos", pagina = 1}
            );

            //rota /Categoria/Paginax
            routes.MapRoute(
                 null,
                 "{categoria}/Pagina{pagina}",
                 new {controller = "Vitrine", action = "ListaProdutos"}, new { pagina= @"\d+" } 
            );

            routes.MapRoute(
                null, "{controller}/{action}");
        }
    }
}
