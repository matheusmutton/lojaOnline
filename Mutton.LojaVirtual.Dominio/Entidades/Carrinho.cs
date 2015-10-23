﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutton.LojaVirtual.Dominio.Entidades
{
     public class Carrinho
    {
        private readonly List<ItemCarrinho> _itemCarrinho = new List<ItemCarrinho>();

        public void AdicionarItem(Produto produto, int quantidade)
        {
            ItemCarrinho item = _itemCarrinho.FirstOrDefault(p => p.Produto.ProdutoId == produto.ProdutoId);

            if (item == null)
            {
                _itemCarrinho.Add(new ItemCarrinho
                {
                    Produto = produto,
                    Quantidade = quantidade
                });
            }
            else
            {
                item.Quantidade += quantidade;
            }


        }

        public void RemoverItem(Produto produto)
        {
            _itemCarrinho.RemoveAll(l => l.Produto.ProdutoId == produto.ProdutoId);
        }
        
        public decimal ObterValorTotal()
        {
            return _itemCarrinho.Sum(e => e.Produto.Preco*e.Quantidade);
        }

        public void LimparCarrinho()
        {
            _itemCarrinho.Clear();
        }

        public IEnumerable<ItemCarrinho> ItensCarrinho
        {
            get { return _itemCarrinho; }
        }
    }


    public class ItemCarrinho
    {
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }
    }
}
    

/*
    public class Carrinho
    {
        private readonly List<ItemCarrinho> _itensCarrinho = new List<ItemCarrinho>();

        //Add (primeiro verifica na list se já existe o produto e soma. Se não existir, cria nova linha)
        public void AdicionarItem(Produto produto, int quantidade)
        {
            ItemCarrinho itemExistente = _itensCarrinho.FirstOrDefault(p => p.Produto.ProdutoId == produto.ProdutoId);

            if(itemExistente == null)
            {
                //cria nova linha                
                _itensCarrinho.Add(new ItemCarrinho 
                { 
                    Produto = produto,
                    Quantidade = quantidade
                });
            }
            else
            {
                //adiciona na Lista, atualiza valor
                itemExistente.Quantidade += quantidade;

            }
        }

        //Remove
        public void RemoverItem(Produto produto)
        {
            _itensCarrinho.RemoveAll(p => p.Produto.ProdutoId == produto.ProdutoId);
        }

        //Obter valor total
        public decimal ObterValorTotal()
        {
            return _itensCarrinho.Sum(e => e.Produto.Preco * e.Quantidade);
        }

        //Limpar carrinho
        public void LimparCarrinho()
        {
            _itensCarrinho.Clear();
        }

        //Lista ItensCarrinho
        public IEnumerable<ItemCarrinho> ItensCarrinho 
        {
            get { return _itensCarrinho; }
        }
    }

    public class ItemCarrinho
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
    }
    */
