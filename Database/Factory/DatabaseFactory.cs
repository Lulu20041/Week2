using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWeek2.Database.Factory
{
    abstract class DatabaseCreator
    {
        public abstract IDatabase CreateDatabase();
    }
}
