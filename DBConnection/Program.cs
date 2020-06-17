using System;

namespace DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opening Connections");
            DBConnection sql = new SQLConnection("sqlConnection");
            DBCommand sqlCmd = new DBCommand(sql, "select * from db;");
            sqlCmd.Execute();

            DBConnection oraclesql = new OracleConnection("oraclesqlConnection");
            DBCommand oracleCmd = new DBCommand(oraclesql, "select * from db;");
            oracleCmd.Execute();
        }
    }
}
