using System;
using System.Threading;

namespace DBConnection
{
    public class SQLConnection : DBConnection
    {
        public SQLConnection(string connection) : base(connection)
        {
        }
        public override void OpenConnection()
        {
            Console.WriteLine("Opening SQL Connection :");
            Console.WriteLine("The connection has opened within {0}", Timeout);
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Closing SQL Connection");
        }
        
    }
}
