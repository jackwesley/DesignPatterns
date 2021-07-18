using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Estructural.Composite
{
    public class InputFormMessage :IMessage
    {
        public string Nome { get; set; }
        public InputFormMessage(string nome)
        {
            Nome = nome;
        }

        public void ExibirMensagens(int sub)
        {
            Console.WriteLine(new string('-', sub) + Nome);
        }
    }
}
