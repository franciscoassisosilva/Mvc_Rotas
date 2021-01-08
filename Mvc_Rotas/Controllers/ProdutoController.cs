using Mvc_Rotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Rotas.Controllers
{
    public class ProdutoController : Controller
    {
        private List<Produto> _listaProdutos;

        public ProdutoController()
        {
            _listaProdutos = Produto.ListarProdutos().OrderBy(p=>p.Preco).ToList();
        }

        public ActionResult Index()
        {
            ViewBag.TituloProdutos = "Todos os Produtos";
            return View(_listaProdutos);
        }

        public ActionResult Detalhes(int produtoId)
        {
            return View(_listaProdutos.FirstOrDefault(p => p.ProdutoId == produtoId));
        }

        public ActionResult Categorias(string categoria)
        {
            ViewBag.Categoria = categoria;
            List<Produto> produtos = _listaProdutos.Where(p => p.Categoria.Equals(categoria)).ToList();
            return View(produtos);
        }

        public ActionResult Cadastrar()
        {
            return View();
        }
	}
}