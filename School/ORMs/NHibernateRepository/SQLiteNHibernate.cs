using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using ORMs.NHibernateRepository.MapModels;

namespace ORMs.NHibernateRepository
{
    public class SQLiteNHibernate : ISessionFactoryCreation
    {
        public ISessionFactory IsessionFactoryCreation()
        {
            return Fluently.Configure()
                 .Database(
                 SQLiteConfiguration.Standard
                 .UsingFile("SchoolDataBase.db")
                        )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<SchoolMap>())
                .ExposeConfiguration(BuildSchema)
                .BuildSessionFactory();
        }
        private void BuildSchema(Configuration config)
        {
            if (File.Exists("SchoolDataBase.db"))
                File.Delete("SchoolDataBase.db");

            new SchemaExport(config)
                .Create(false, true);
        }


    }

}


