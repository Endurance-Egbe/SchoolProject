using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ORMs.EFCoreRepository
{
    public class SQLServerEFCore : ADBContext
    {
        protected override void InitialiseDatabase(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;
                                            Initial Catalog=EFCoreSQLServer;Integrated Security=True;Connect Timeout=30;
                                            Encrypt=False;TrustServerCertificate=False;
                                            ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        }
    }
}
