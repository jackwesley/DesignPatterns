using DesingPatterns.Estructural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Behavorial.Strategy
{
    public class PagamentoTransferenciaService : IPagamento
    {
        private readonly IPagamentoTransferenciaFacade _pagamentoTransfFacade;

        public PagamentoTransferenciaService(IPagamentoTransferenciaFacade pagamentoTransfFacade)
        {
            _pagamentoTransfFacade = pagamentoTransfFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine($"Iniciando pagamento via transferencia - valor R$ {pagamento.Valor} ");

            pagamento.ConfirmacaoTransferencia = _pagamentoTransfFacade.RealizarTransferencia();
            pagamento.Status = "Pago via Transferencia";
            return pagamento;
        }
    }
}
