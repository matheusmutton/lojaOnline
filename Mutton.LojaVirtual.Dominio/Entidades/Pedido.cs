﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutton.LojaVirtual.Dominio.Entidades
{
    public class Pedido
    {
        [Required(ErrorMessage = "Informe seu nome")]
        [Display(Name = "Nome do cliente:")]
        public string NomeCliente { get; set; }

        [Display(Name = "Cep:")]
        public string CEP { get; set; }
        
        [Required(ErrorMessage = "Informe seu endereço")]
        [Display(Name = "Endereço:")]
        public string Endereco { get; set; }

        [Display(Name = "Complemento:")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Informe seu estado")]
        [Display(Name = "Estado:")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Informe sua cidade")]
        [Display(Name = "Cidade:")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informe seu bairro")]
        [Display(Name = "Bairro:")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Informe seu e-mail")]
        [Display(Name = "E-mail:")]
        [EmailAddress(ErrorMessage="E-mail inválido")]
        public string Email { get; set; }
        
        [Display(Name = "Embrulhar para presente?")]
        public bool EmbrulhaPresente { get; set; }
    }
}
