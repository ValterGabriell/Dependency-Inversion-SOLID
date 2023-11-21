using System;

namespace DependencyInversionSOLID
{
    public class NotaFiscal
    {
        public int PedidoId { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
    }

    public class NotaFiscalDAO : ISalvarNotaFiscal
    {
        public void Salvar(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Salvando no Banco de Dados " + notaFiscal.PedidoId);
        }
    }
    
    public class NotaFiscalTest : ISalvarNotaFiscal
    {
        public void Salvar(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Testando gravação em memória " + notaFiscal.PedidoId);
        }
    }
}