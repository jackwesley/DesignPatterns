using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Estructural.Facade.CrossCutting
{
    public interface IPayPalGateway
    {
        bool CommitTransaction(string cardHashKey, string orderId, decimal amount);

        string GetCardHashKey(string serviceKey, string cartaoCredito);

        string GetPaypalServiceKey(string apiKey, string encriptionKey);
    }
}
