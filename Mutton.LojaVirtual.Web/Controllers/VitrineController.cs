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

        public ActionResult ListaProdutos(int pagina = 1)
        {
            _reposito = new ProdutosRepositorio();

            ProdutosViewModel model = new ProdutosViewModel()
            {
                Produtos = _reposito.Produtos
                .OrderBy(p => p.Nome)
                //.OrderBy(p => p.Descricao)
                .Skip((pagina -1) * ProdutosPorPagina)
                .Take(ProdutosPorPagina),

                Paginacao = new Paginacao()
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    ItensTotal = _reposito.Produtos.Count()
                }
            };

            //return View(produtos);
            return View(model);
        }
	}
}