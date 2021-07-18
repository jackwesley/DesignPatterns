using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Behavorial.Strategy
{
    public class PagamentoTransferenciaFacade : IPagamentoTransferenciaFacade
    {
        public string RealizarTransferencia()
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                 .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
