using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWeek2
{
    class SQLServerDatabaseCreator : DatabaseCreator
    {
        public override IDatabase CreateDatabase()
        {
            return new SQLServerDatabase();
        }
    }
}
