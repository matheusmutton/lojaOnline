using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Mutton.LojaVirtual.Web.HtmlHelpers;
using Mutton.LojaVirtual.Web.Models;

namespace Mutton.LojaVirtual.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Take()
        {
            int[] numeros = {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            var resultado = from num in numeros.Take(5) select num;

            //int[] numTest = { 5, 4, 1, 3, 8 };
            int[] numTest = { 5, 4, 1, 3, 9 };
            CollectionAssert.AreEqual(resultado.ToArray(), numTest);
        }

        [TestMethod]
        public void Skip()
        {
            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var resultado = from num in numeros.Take(5).Skip(2) select num;

            //int[] numTest = { 5, 4, 1, 3, 8 };
            int[] numTest = { 1, 3, 9  };
            CollectionAssert.AreEqual(resultado.ToArray(), numTest);
        }

        [TestMethod]
        public void TestePaginacaoGeradaCorretamente()
        {
            //Testando com AAA (arrange, Act, Assert)

            //Arrange (preparação)
            HtmlHelper html = null;
            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                ItensPorPagina = 10,
                ItensTotal = 28
            };
            Func<int, string> paginaUrl = i => "Pagina" + i;

            //Act (estimular sistema sendo testado)
            MvcHtmlString resultado = html.PaginacaoLinks(paginacao, paginaUrl);


            //Assert (verificar se resultados obtidos = resultados esperados)
            Assert.AreEqual(
                @"<a class=""btn btn-default"" href=""Pagina1"">1</a>" +
                @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>" +
                @"<a class=""btn btn-default"" href=""Pagina3"">3</a>"
                , resultado.ToString());
        }
    }
}
