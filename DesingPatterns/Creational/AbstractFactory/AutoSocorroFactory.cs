using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory2
{
    //Abstract Factory -
    public abstract class AutoSocorroFactory
    {
        //Cria produtos diferentes mas que tem algum tipo de interação entre si
        public abstract Guincho CriarGuincho();
        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
    }
}
