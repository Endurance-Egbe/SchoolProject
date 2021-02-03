using FluentNHibernate.Mapping;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMs.NHibernateRepository.MapModels
{
    public class SchoolClassMap : ClassMap<SchoolClass>
    {
        public SchoolClassMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            References(x => x.Teacher);
            References(x => x.School);
            HasMany(x => x.Students);
            HasMany(x => x.Subjects);
        }
    }
}
