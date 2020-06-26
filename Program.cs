using System;
using System.Collections.Generic;

namespace Aula26
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();
            Produto p1 = new Produto(1, "Lápis", 1.50f);
            Produto p2 = new Produto(2, "Borracha", 1.00f);
            Produto p3 = new Produto(3, "Caneta", 1.50f);
            Produto p4 = new Produto(4, "Apontador", 2.50f);
            Produto p5 = new Produto(5, "Caderno 10 Matérias", 20.70f);

            //Adicionando os produtos no carrinho:
            cart.Cadastrar(p1);
            cart.Cadastrar(p2);
            cart.Cadastrar(p3);
            cart.Cadastrar(p4);
            cart.Cadastrar(p5);
            
            //Remover um produto
            cart.Deletar(p2);

            //Substituição de produto 
            Produto p6 = new Produto(6, "Borracha em Caneta", 3.50f);
            cart.Alterar(2, p6);

            //Mostrar a Lista:
            cart.Listar();
            
            //Mostrar valor total:
            cart.MostrarValor();

        }
    }
}
