using DesingPatterns.Estructural.Facade.CrossCutting;
using DesingPatterns.Estructural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Behavorial.Strategy
{
    public class PagamentoFactory
    {
        public static IPagamento CreatePagamento(MeioPagamento meioPagamento)
        {
            switch (meioPagamento)
            {
                case MeioPagamento.CartaoCredito:
                    return new PagamentoCartaoCreditoService(
                                new PagamentoCartaoCreditoFacade(
                                    new PaypalGateway(),
                                    new ConfigurationManager()));
                case MeioPagamento.Boleto:
                    return new PagamentoBoletoService(new PagamentoBoletoFacade());
                case MeioPagamento.TransferenciaBancaria:
                    return new PagamentoTransferenciaService(new PagamentoTransferenciaFacade());
                default:
                    throw new ApplicationException("Meio de pagamento nao encontrado");
            }
        }
    }
}
