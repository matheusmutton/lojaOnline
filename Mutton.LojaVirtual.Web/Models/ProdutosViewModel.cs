using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mutton.LojaVirtual.Dominio.Entidades;

namespace Mutton.LojaVirtual.Web.Models
{
    // Classe q representa itens do Dominio
    public class ProdutosViewModel
    {
        public IEnumerable<Produto> Produtos { get; set; }
        public Paginacao Paginacao { get; set; }
        public string CategoriaAtual { get; set; }


    }
}