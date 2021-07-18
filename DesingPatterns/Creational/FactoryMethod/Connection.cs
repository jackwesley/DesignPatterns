using System;

namespace DesingPatterns.FactoryMethod
{
    public class Connection
    {
        public string ConnectionString { get; set; }

        public bool Opened { get; set; }

        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine("Executando comando: " + command);
        }

        public void Open()
        {
            Console.WriteLine("Conexão Aberta!");
        }

        public void Close()
        {
            Console.WriteLine("Conexão fechada!");
        }
    }
}
