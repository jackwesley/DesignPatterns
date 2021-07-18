using System;

namespace DesingPatterns.Behavorial.Observer
{
    public class ExecucaoObserver
    {
        public void Executar()
        {
            var joao = new Observador("Joao");
            var eduardo = new Observador("Eduardo");
            var bill = new Observador("Bill");

            var amazon = new PapelBovespa("Amazon", NextDecimal());
            var microsoft = new PapelBovespa("Microsoft", NextDecimal());

            amazon.Subscribe(joao);
            amazon.Subscribe(eduardo);

            microsoft.Subscribe(eduardo);
            microsoft.Subscribe(bill);

            Console.WriteLine("");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                amazon.Valor = NextDecimal();
                microsoft.Valor = NextDecimal();

                if(i == 1)
                {
                    amazon.UnSubscribe(eduardo);
                }
            }
        }

        private decimal NextDecimal()
        {
            var random = new Random();
            var r = random.Next(141421, 314160);
            return r / (decimal)100000.00;
        }
    }
}
