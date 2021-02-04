using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using ORMs.NHibernateRepository.MapModels;

namespace ORMs.NHibernateRepository
{
    public class SQLServerNHibernate : ISessionFactoryCreation
    {
        public ISessionFactory IsessionFactoryCreation()
        {
            return Fluently.Configure()
                 .Database(MsSqlConfiguration
                 .MsSql2012
                 .ConnectionString
                 (@"Data Source=(localdb)\ProjectsV13;
                    Initial Catalog=SchoolDBNHibernate;Integrated Security=True;
                    Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                    ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SchoolMap>())
                    .ExposeConfiguration(Cfg => new SchemaExport(Cfg)
                    .Create(false, true))
                    .BuildSessionFactory();

        }
    }
}
