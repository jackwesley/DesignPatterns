using System;
using System.Collections.Generic;

namespace DesingPatterns.Singleton
{
    //Singleton
    internal sealed class LoadBalancerSingleton
    {
        private static readonly LoadBalancerSingleton Instance = new LoadBalancerSingleton();

        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        private LoadBalancerSingleton()
        {
            _servers = new List<Server>
            {
                new Server{ Id = Guid.NewGuid(), Name = "ServcerI", IP= "120.14.220.18"},
                new Server{ Id = Guid.NewGuid(), Name = "ServcerII", IP= "120.14.220.19"},
                new Server{ Id = Guid.NewGuid(), Name = "ServcerIII", IP= "120.14.220.20"},
                new Server{ Id = Guid.NewGuid(), Name = "ServcerIV", IP= "120.14.220.21"},
                new Server{ Id = Guid.NewGuid(), Name = "ServcerV", IP= "120.14.220.22"},
            };
        }

        public static LoadBalancerSingleton GetLoadBalancer()
        {
            return Instance;
        }

        public Server NextServer
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}
