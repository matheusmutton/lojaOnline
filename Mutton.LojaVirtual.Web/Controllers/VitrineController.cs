using Mutton.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mutton.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _reposito;
        public int ProdutosPorPagina = 8;

        public ActionResult ListaProdutos(int pagina = 1)
        {
            _reposito = new ProdutosRepositorio();

            //List<Produto> produtos = _reposito.Produtos.Take(10).ToList();
            var produtos = _reposito.Produtos
                .OrderBy(p => p.Nome)
                //.OrderBy(p => p.Descricao)
                .Skip((pagina -1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina);
            

            return View(produtos);
        }
	}
}