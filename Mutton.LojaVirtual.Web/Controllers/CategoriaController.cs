using Mutton.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mutton.LojaVirtual.Web.Controllers
{
    public class CategoriaController : Controller
    {

        private ProdutosRepositorio _reposito;
        //
        // GET: /Categoria/
        public PartialViewResult Menu(string categoria = null)
        {
            ViewBag.CategoriaSelecionada = categoria;
            _reposito = new ProdutosRepositorio();

            IEnumerable<string> categorias = _reposito.Produtos
                .Select(c => c.Categoria)
                .Distinct()
                .OrderBy(c => c);


            return PartialView(categorias);
        }
	}
}