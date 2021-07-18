using System;

namespace DesingPatterns.FactoryMethod
{
    //Abstract Creator
    public abstract class DbFactory
    {
        //Factory Method
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory DataBase(DataBaseType dataBase)
        {
            if (dataBase == DataBaseType.SqlServer)
                return new SqlFactory();

            if (dataBase == DataBaseType.Oracle)
                return new OracleFactory();

            throw new ApplicationException("Banco de dados desconhecido");
        }

    }
}
