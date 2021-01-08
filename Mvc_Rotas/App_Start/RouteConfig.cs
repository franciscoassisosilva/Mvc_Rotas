using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mvc_Rotas
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Produtos",
                url: "Produtos/",
                defaults: new { controller = "Produto", action = "Index" }
            );

            routes.MapRoute(
                name: "Detalhes",
                url: "Produtos/{produtoId}",
                defaults: new { controller = "Produto", action = "Detalhes" },
                constraints: new { produtoId = @"\d+" }
            );

            routes.MapRoute(
                name: "CadastrarProduto",
                url: "Produtos/Cadastrar",
                defaults: new { controller = "Produto", action = "Cadastrar" }
            );

            routes.MapRoute(
                name: "Categorias",
                url: "Produtos/{categoria}",
                defaults: new { controller = "Produto", action = "Categorias" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Produto", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
