using System;

namespace DesingPatterns.Singleton
{
    public class Server
    {
        public Guid Id { get; set; }
        public string Name { get; internal set; }
        public string IP { get; internal set; }
    }
}
