using DatabaseManager.EntityClasses;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Security;
using System.Reflection;
using System.Threading;


namespace DatabaseManager
{
    // https://refactoring.guru/design-patterns/singleton/csharp/example#example-1
    // This DatabaseHandler (Singleton) implementation is called "double check lock". It is safe
    // in multithreaded environment and provides lazy initialization for the
    // Singleton object.
    public class DatabaseHandler
    {
        private DatabaseHandler() {}

        private static DatabaseHandler _instance;

        private string ConnectionString;

        private MySqlConnection Connection;

        public MySqlCommand Command;

        // We now have a lock object that will be used to synchronize threads
        // during first access to the Singleton.
        private static readonly object _lock = new object();

        public static DatabaseHandler GetInstance(string connectionString)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    { 
                        _instance = new DatabaseHandler();
                        _instance.ConnectionString = connectionString;
                        _instance.Connection = new MySqlConnection(connectionString);
                    }
                }
            }
            return _instance;
        }

        public static DatabaseHandler GetInstance()
        {
            if (_instance != null)
            {
                return _instance;
            }
            else 
            { 
                return null; 
            }

        }

        public void ConnectionOpen()
        {
            if (_instance != null)
            {
                if (_instance.Connection != null)
                { 
                    _instance.Connection.Open();
                }
            }
        }

        public void ConnectionClose()
        {
            if (_instance != null)
            {
                if (_instance.Connection != null)
                {
                    _instance.Connection.Close();
                }
            }
        }

        public int ExecuteNonQuery(string commandString)
        {
            int rowsAffected = 0;
            try
            {
                if (_instance != null)
                {
                    _instance.Command = new MySqlCommand(commandString, _instance.Connection);
                    rowsAffected = _instance.Command.ExecuteNonQuery();
                }
            }
            catch (Exception ex) 
            {
                rowsAffected = -1;
            }
            return rowsAffected;
        }

        public List<T> ExecuteQuery<T>(string query) where T : new()
        {
            var result = new List<T>();

            if (_instance != null)
            {
                if (_instance.Connection != null)
                {
                    _instance.Connection.Open();
                    _instance.Command = new MySqlCommand(query, _instance.Connection);
                    using (var reader = _instance.Command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var obj = DatabaseMappers.MapRowToObject<T>(reader);
                            result.Add(obj);
                        }
                    }
                    _instance.Connection.Close();
                }
            }

            return result;
        }

        public List<User> GetUsers()
        {
            List<DatabaseManager.EntityClasses.User> users = null;
            try
            {
                string selectSql = "SELECT * FROM users WHERE username = 'demo'";

                users = ExecuteQuery<DatabaseManager.EntityClasses.User>(selectSql);
            }
            catch (Exception ex)
            {
            }
            return users;
        }

    }
}



