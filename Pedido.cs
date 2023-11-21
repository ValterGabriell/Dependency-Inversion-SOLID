using System;
using System.Collections.Generic;

namespace DependencyInversionSOLID
{
    public class Pedido
    {
        public int Id { get; set; }
        public List<Produto> Produtos { get; set; }
        private ISalvarNotaFiscal _salvarNotaFiscal;

        public Pedido(ISalvarNotaFiscal salvarNotaFiscal)
        {
            _salvarNotaFiscal = salvarNotaFiscal;
        }

        public void GerarNotaFiscal()
        {
            // Calcula o valor total do pedido
            decimal valorTotal = 0;
            foreach (var produto in Produtos)
            {
                valorTotal += produto.Preco;
            }

            // Gera a nota fiscal
            NotaFiscal notaFiscal = new NotaFiscal();
            notaFiscal.PedidoId = Id;
            notaFiscal.Valor = valorTotal;
            notaFiscal.Data = DateTime.Now;

            // Salva a nota fiscal no banco de dados
            _salvarNotaFiscal.Salvar(notaFiscal);
        }
    }
}