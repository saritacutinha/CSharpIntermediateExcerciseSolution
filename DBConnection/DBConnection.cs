using System;
using System.Data;

namespace DBConnection
{
    public abstract class DBConnection
    {
        protected string  ConnectionString { get; private set; }
        protected TimeSpan Timeout { get; set; } = new TimeSpan(30);

        protected DBConnection(string connection)
        {
            if (connection != null)
                ConnectionString = connection;
                
            else
                throw new InvalidConstraintException();

        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();


    }
}
