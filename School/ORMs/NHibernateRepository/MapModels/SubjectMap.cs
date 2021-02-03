using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Models;

namespace ORMs.NHibernateRepository.MapModels
{
    public class SubjectMap : ClassMap<Subject>
    {
        public SubjectMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            References(x => x.Teacher);
            References(x => x.SchoolClass);
            HasManyToMany(x => x.Students);
        }
    }
}
