using System;
using System.Collections.Generic;

namespace DependencyInversionSOLID
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Produto produto = new Produto();
      produto.Name = "PS5";
      produto.Preco = 4790;
      produto.Id = new Random().Next();

      var listaProdutos = new List<Produto>();
      listaProdutos.Add(produto);
      
      var dao = new NotaFiscalTest();
      Pedido pedido = new Pedido(dao);
      pedido.Id = new Random().Next();
      pedido.Produtos = listaProdutos;
      
      pedido.GerarNotaFiscal();
    }
  }
}