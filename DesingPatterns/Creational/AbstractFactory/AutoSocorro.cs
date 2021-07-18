﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.AbstractFactory2
{
    //Client class
    public class AutoSocorro
    {
        private readonly Veiculo _veiculo;
        private readonly Guincho _guincho;

        public AutoSocorro(AutoSocorroFactory factory, Veiculo veiculo)
        {
            _veiculo = factory.CriarVeiculo(veiculo.Modelo, veiculo.Porte);
            _guincho = factory.CriarGuincho();
        }

        public void RealizarAtendimento()
        {
            _guincho.Socorrer(_veiculo);
        }

        public static AutoSocorro CriarAutoSocorro(Veiculo veiculo)
        {
            switch (veiculo.Porte)
            {
                case Porte.Pequeno:
                    return new AutoSocorro(new SocorroVeiculoPequenoFactory(), veiculo);
                case Porte.Medio:
                    return new AutoSocorro(new SocorroVeiculoMedioFactory(), veiculo);
                case Porte.Grande:
                    return new AutoSocorro(new SocorroVeiculoGrandeFactory(), veiculo);
                default:
                    throw new ApplicationException("Não foi possível identificar o veículo");
            }
        }
    }
}
