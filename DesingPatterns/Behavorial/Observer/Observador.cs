using System;

namespace DesingPatterns.Behavorial.Observer
{
    //Concrete observer
    public class Observador : IObservador
    {
        public string Nome { get ; set ; }

        public Observador(string nome)
        {
            Nome = nome;
        }

        public void Notificar(Investimento investimento)
        {
            Console.WriteLine("Notificando {0} que {1} teve preço alterado para {2:C}", Nome, investimento.Simbolo, investimento.Valor);
        }
    }
}
