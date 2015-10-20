using Mutton.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mutton.LojaVirtual.Web.Models;

namespace Mutton.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _reposito;
        public int ProdutosPorPagina = 8;

        public ActionResult ListaProdutos(string categoria, int pagina = 1)
        {
            _reposito = new ProdutosRepositorio();

            ProdutosViewModel model = new ProdutosViewModel()
            {
                Produtos = _reposito.Produtos
                .Where(p=> categoria == null || p.Categoria == categoria)
                .OrderBy(p => p.Nome)
                .Skip((pagina -1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina),

                Paginacao = new Paginacao()
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    ItensTotal = _reposito.Produtos.Count()
                },

                CategoriaAtual = categoria
            };

            return View(model);
        }
	}
}