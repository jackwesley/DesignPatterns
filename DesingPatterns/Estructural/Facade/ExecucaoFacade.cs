using DesingPatterns.Estructural.Facade.CrossCutting;
using DesingPatterns.Estructural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Facade
{
    public class ExecucaoFacade
    {
        public static void Executar()
        {
            var produtos = new List<Produto>
            {
                new Produto{Nome ="Tenis Adidas", Valor = new Random().Next(500)},
                new Produto{Nome ="Camisa Boliche", Valor = new Random().Next(500)},
                new Produto{Nome ="Raquete Tenis", Valor = new Random().Next(500)},
            };

            var pedido = new Pedido
            {
                Id = Guid.NewGuid(),
                Produtos = produtos
            };

            var pagamento = new Pagamento
            {
                CartaoCredito = "5555 2222 5555 9999"
            };

            //Resolva com DI
            var pagamentoService = new PagamentoCartaoCreditoService(new PagamentoCartaoCreditoFacade(new PaypalGateway(), new ConfigurationManager()));

            var pagamentoResult = pagamentoService.RealizarPagamento(pedido, pagamento);

            Console.WriteLine(pagamentoResult.Status);
        }
    }
}
