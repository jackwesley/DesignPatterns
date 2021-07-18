using DesingPatterns.Estructural.Facade.CrossCutting;
using System;

namespace DesingPatterns.Estructural.Facade.Domain
{
    public class PagamentoCartaoCreditoFacade : IPagamentoCartaoCreditoFacade
    {
        private readonly IPayPalGateway _paypalGateway;
        private readonly IConfigurationManager _configurationManager;

        public PagamentoCartaoCreditoFacade(IPayPalGateway paypalGateway, IConfigurationManager configurationManager)
        {
            _paypalGateway = paypalGateway;
            _configurationManager = configurationManager;
        }

        public bool RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            var apiKey = _configurationManager.GetValue("apiKey");
            var encriptionKey = _configurationManager.GetValue("encriptionKey");

            var serviceKey = _paypalGateway.GetPaypalServiceKey(apiKey, encriptionKey);
            var cardHashKey = _paypalGateway.GetCardHashKey(serviceKey, pagamento.CartaoCredito);

            var pagamentoResult = _paypalGateway.CommitTransaction(cardHashKey, pedido.Id.ToString(), pagamento.Valor);

            return pagamentoResult;
        }
    }
}
