using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Behavorial.Command
{
    public class ExecucaoCommand
    {

        public static void Executar()
        {
            var user = new Usuario();

            user.Adicionar('+', 100);
            Console.ReadKey();
            user.Adicionar('-', 50);
            Console.ReadKey();
            user.Adicionar('*', 10);
            Console.ReadKey();
            user.Adicionar('/', 2);
            Console.ReadKey();

            user.Desfazer(4);
            Console.ReadKey();

            user.Retornar(3);
        }
    }
}
