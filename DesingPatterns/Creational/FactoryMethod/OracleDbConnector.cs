using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.FactoryMethod
{
    public class OracleDbConnector : DbConnector
    {
        public OracleDbConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }

        public override Connection Connect()
        {
            Console.WriteLine("Connectando ao banco de dados Oracle");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
