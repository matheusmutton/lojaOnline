using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mutton.LojaVirtual.Dominio.Entidades;
using Mutton.LojaVirtual.Dominio.Repositorio;

namespace Mutton.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutosRepositorio _reposito;

        //
        // GET: /Produto/
        public ActionResult Index()
        {
            _reposito = new ProdutosRepositorio();
            
            //var produtos = _reposito.Produtos.Take(10);
            List<Produto> produtos = _reposito.Produtos.Take(10).ToList();
            
            return View(produtos);
        }
	}
}