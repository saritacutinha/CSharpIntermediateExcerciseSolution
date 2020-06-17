using System;

namespace DBConnection
{
    public class OracleConnection : DBConnection
    {
        public OracleConnection(string connection) : base(connection)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening Oracle SQL Connection :");
            Console.WriteLine("The connection has opened within {0}", Timeout);
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Closing Oracle SQL Connection");
        }
    }
}
