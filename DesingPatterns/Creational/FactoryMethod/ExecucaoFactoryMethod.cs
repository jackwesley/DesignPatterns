using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.FactoryMethod
{
    public class ExecucaoFactoryMethod
    {
        public static void Executar()
        {
            var sqlCn = DbFactory.DataBase(DataBaseType.SqlServer)
                                 .CreateConnector("minhaCS")
                                 .Connect();

            sqlCn.ExecuteCommand("select * from TableSQL");
            sqlCn.Close();

            Console.WriteLine("");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");

            var oracleCn = DbFactory.DataBase(DataBaseType.Oracle)
                                    .CreateConnector("minhaCS")
                                    .Connect();

            oracleCn.ExecuteCommand("Select * from tabelaOracle");
            oracleCn.Close();
        }
    }
}
