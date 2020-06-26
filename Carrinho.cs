using System;
using System.Collections.Generic;

namespace Aula26 {
    public class Carrinho : ICarrinho
    //Ao fazermos a herança entre a classe Carrinho e a Interface ICarrinho, todos os métodos já aparecem diretp
    {
        public float ValorTotal { get; set; }
        List<Produto> carrinho = new List<Produto> ();
        public void Alterar (int _cod, Produto _produto) {
            carrinho.Find (x => x.Codigo == _cod).Nome = _produto.Nome;
            carrinho.Find (y => y.Codigo == _cod).Preco = _produto.Preco;
        }

        public void Cadastrar (Produto _produto) {
            carrinho.Add (_produto);
        }

        public void Deletar (Produto _produto) {
            carrinho.Remove (_produto);
        }

        public void Listar () {
            foreach (Produto item in carrinho) {
                Console.WriteLine ($"Nome: {item.Nome} - Preço: R$ {item.Preco}");
            }
        }

        public void MostrarValor(){
            foreach (Produto item in carrinho){
                ValorTotal += item.Preco;
            } 
            Console.WriteLine($"Valor total: R$ {ValorTotal}");
            Console.ResetColor();
        }

    }
}