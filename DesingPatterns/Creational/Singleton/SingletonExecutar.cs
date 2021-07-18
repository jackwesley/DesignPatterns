using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Singleton
{
    public class SingletonExecutar
    {
        public static void Executar()
        {
            var b1 = LoadBalancerSingleton.GetLoadBalancer();
            var b2 = LoadBalancerSingleton.GetLoadBalancer();
            var b3 = LoadBalancerSingleton.GetLoadBalancer();
            var b4 = LoadBalancerSingleton.GetLoadBalancer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Mesma Instância\n");
            }

            var balancer = LoadBalancerSingleton.GetLoadBalancer();

            for (int i = 0; i < 15; i++)
            {
                var serverName = balancer.NextServer.Name;
                Console.WriteLine("Disparado request para: " + serverName);
            }
        }
    }
}
