using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerArchitecture.Data
{
    public interface IDbManager
    {
        string ConnectionString { get;}
    }
}
