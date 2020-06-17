using System;

namespace DBConnection
{
    public class DBCommand
    {
        private readonly DBConnection _connection;
        public string Command { get; private set; }

        public DBCommand(DBConnection connection, string command)
        {
            if (connection != null && command != null || command != "" )
            {
                _connection = connection;
                Command = command;
            }
            
            else
                throw new InvalidCastException();
        }

        public void Execute()
        {
            _connection.OpenConnection();
            Console.WriteLine("Connection has been opened");
            Console.WriteLine("Run the command {0}",Command);
            _connection.CloseConnection();
            Console.WriteLine("Connection has been closed");

        }

    }
}
