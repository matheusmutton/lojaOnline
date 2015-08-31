using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mutton.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        //total de itens no banco
        public int ItensTotal { get; set; }
        //toal de itens exibidos por pagina
        public int ItensPorPagina { get; set; }
        //pagina atual q esta sendo exibida
        public int PaginaAtual { get; set; }
        //total de paginas q serão exibidas
        public int TotalPaginas
        {
            get
            {
                return (int) Math.Ceiling((decimal) ItensTotal/ItensPorPagina);
            }
        }

    }
}