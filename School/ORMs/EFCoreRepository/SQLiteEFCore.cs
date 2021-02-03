using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ORMs.EFCoreRepository
{
    public class SQLiteEFCore : ADBContext
    {
        public SQLiteEFCore() : base()
        {

        }

        protected override void InitialiseDatabase(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite
                ("data source=SchoolDatabaseEfCSqlite.db");
        }


    }
}
