using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Models;

namespace ORMs.NHibernateRepository.MapModels
{
    public class StudentMap : ClassMap<Student>
    {
        public StudentMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Location);
            Map(x => x.Gender);
            References(x => x.School);
            References(x => x.SchoolClass);
            HasManyToMany(x => x.Subjects).Cascade.All().Table("Enrollment");
        }
    }
}
