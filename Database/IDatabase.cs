using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWeek2.Database
{
    interface IDatabase : IDisposable
    {
        public void OpenConnection();

        public SqlConnection Connection { get; }
    }
}
