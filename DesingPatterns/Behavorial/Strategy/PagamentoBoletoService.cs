using DesingPatterns.Estructural.Facade.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Behavorial.Strategy
{
    public class PagamentoBoletoService : IPagamento
    {
        private readonly IPagamentoBoletoFacade _pagamentoBoletoFacade;

        public PagamentoBoletoService(IPagamentoBoletoFacade pagamentoBoletoFacade)
        {
            _pagamentoBoletoFacade = pagamentoBoletoFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine($"Iniciando pagamento via boleto - valor R$ {pagamento.Valor} ");

            pagamento.LinhaDigitavelBoleto = _pagamentoBoletoFacade.GerarBoleto();
            pagamento.Status = "Aguardando Pagamento";
            return pagamento;
        }
    }
}
