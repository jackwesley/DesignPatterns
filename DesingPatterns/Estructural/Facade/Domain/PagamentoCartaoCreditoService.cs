using System;
using System.Linq;

namespace DesingPatterns.Estructural.Facade.Domain
{
    public class PagamentoCartaoCreditoService : IPagamento
    {
        private readonly IPagamentoCartaoCreditoFacade _pagamentoCartaoCreditoFacade;

        public PagamentoCartaoCreditoService(IPagamentoCartaoCreditoFacade pagamentoCartaoCreditoFacade)
        {
            _pagamentoCartaoCreditoFacade = pagamentoCartaoCreditoFacade;
        }
        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine($"Iniciando pagamento via Cartão de Crédito - valor R$ {pagamento.Valor} ");

            if (_pagamentoCartaoCreditoFacade.RealizarPagamento(pedido, pagamento))
            {
                pagamento.Status = "Pago via cartão de crédito";
                return pagamento;
            }

            pagamento.Status = "Cartao de crédito recusado!";
            return pagamento;
        }
    }
}
