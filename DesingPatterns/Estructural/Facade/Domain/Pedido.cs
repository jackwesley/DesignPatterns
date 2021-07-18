using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Estructural.Facade.Domain
{
    public class Pedido
    {
        public Guid Id { get; internal set; }
        public List<Produto> Produtos { get; internal set; }
    }
}
