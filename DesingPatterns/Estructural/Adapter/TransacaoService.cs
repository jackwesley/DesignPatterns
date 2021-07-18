using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Adapter
{
    //Client
    public class TransacaoService
    {
        private readonly ILogger _logger;

        public TransacaoService(ILogger logger)
        {
            _logger = logger;
        }

        public void RealizarTransacao()
        {
            //Transação
            _logger.Log("Transacao realizada");
        }
    }
}
