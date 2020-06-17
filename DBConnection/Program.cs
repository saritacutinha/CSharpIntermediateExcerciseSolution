using System;

namespace DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opening Connections");
            DBConnection sql = new SQLConnection("sqlConnection");
            sql.OpenConnection();


            OracleConnection oracle = new OracleConnection("oracleSqlConnection");
            oracle.OpenConnection();
            oracle.CloseConnection();

            sql.CloseConnection();
        }
    }
}
