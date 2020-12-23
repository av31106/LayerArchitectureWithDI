using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerArchitecture.Data
{
    public class SqliteDbManager : ISqliteDbManager
    {
        private readonly string _connectionString;

        public SqliteDbManager()
        {
            _connectionString = GetConnectionString();
        }

        public string ConnectionString { get { return _connectionString; } }

        private string GetConnectionString(string StringName = "SqliteConnectionString")
        {
            return ConfigurationManager.ConnectionStrings[StringName].ConnectionString;
        }

    }
}
