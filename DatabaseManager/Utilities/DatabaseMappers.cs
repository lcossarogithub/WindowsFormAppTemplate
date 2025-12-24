using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager
{

    public class DatabaseMappers
    {

        public static T MapRowToObject<T>(MySqlDataReader reader) where T : new()
        {
            T obj = new T();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                var property = typeof(T).GetProperty(reader.GetName(i), BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
                if (property != null && reader[i] != DBNull.Value)
                {
                    property.SetValue(obj, Convert.ChangeType(reader[i], property.PropertyType));
                }
            }

            return obj;
        }

    }


}
