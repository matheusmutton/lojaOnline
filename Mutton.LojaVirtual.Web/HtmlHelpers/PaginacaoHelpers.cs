using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Mutton.LojaVirtual.Web.Models;

namespace Mutton.LojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelpers
    {
        public static MvcHtmlString PaginacaoLinks(this HtmlHelper html, Paginacao paginacao, Func<int,string> paginaUrl )
        {
            StringBuilder resultado = new StringBuilder();
            for (int i = 1; i <= paginacao.TotalPaginas; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", paginaUrl(i));
                tag.InnerHtml = i.ToString();
                tag.AddCssClass("btn-default");

                if (i == paginacao.PaginaAtual)
                {
                    //se for a página atual, adiciona classes do bootstrap
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }

                resultado.Append(tag);
            }

            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}