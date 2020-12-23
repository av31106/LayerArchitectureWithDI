using LayerArchitecture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerArchitecture.Services
{
    public class Demo : IDemo
    {
        private readonly IDbManager _dbManager;
        //public Demo()
        //{
        //    _dbManager = new SqliteDbManager();
        //}
        public Demo(IDbManager dbManager)
        {
            _dbManager = dbManager;
        }
    }
}
