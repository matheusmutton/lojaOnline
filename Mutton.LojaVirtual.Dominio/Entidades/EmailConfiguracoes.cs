using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutton.LojaVirtual.Dominio.Entidades
{
    public class EmailConfiguracoes
    {
        public bool UsarSsl = false;
        public string ServidorSmtp = "smtp.muttonlojavirtual.com.br";
        public int ServidorPorta = 587;
        public string Usuario = "mutton";
        public bool EscreverArquivo = false;
        public string PastaArquivo = @"c:\LojaVirtualEmail";
        public string De = "mutton@muttonlojavirtual.com.br";
        public string Para = "pedido@muttonlojavirtual.com.br";

    }
}
