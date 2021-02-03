using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Models;


namespace ORMs.NHibernateRepository.MapModels
{
    public class SchoolMap : ClassMap<SchoolModel>
    {
        public SchoolMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Location);
            References(x => x.Principal).Cascade.All();
            HasMany(x => x.SchoolClasses).Cascade.All();
            HasMany(x => x.Students).Cascade.All();
            HasMany(x => x.Teachers).Cascade.All();
        }
    }
}
