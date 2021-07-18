using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Estructural.Composite
{
    public class Mensagem : IMessage, IEnumerable<IMessage>
    {
        private readonly List<IMessage> _lista = new List<IMessage>();
        public string Nome { get; set; }

        public Mensagem(string nome)
        {
            Nome = nome;
        }

        public void AdicionarFilha(IMessage filha)
        {
            _lista.Add(filha);
        }

        public void RemoverFilha(IMessage filha)
        {
            _lista.Remove(filha);
        }

        public IMessage ObterFilha(int index)
        {
            return _lista[index];
        }

        public void ExibirMensagens(int sub)
        {
            Console.WriteLine(new string('-', sub) + Nome);
            foreach (var mensagem in _lista)
            {
                mensagem.ExibirMensagens(sub + 2);
            }
        }

        public IEnumerable<IMessage> ObterLista()
        {
            return _lista;
        }

        public IEnumerator<IMessage> GetEnumerator()
        {
            return ((IEnumerable<IMessage>)_lista).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<IMessage>)_lista).GetEnumerator();
        }
    }
}
