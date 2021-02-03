using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Models;

namespace ORMs.NHibernateRepository.MapModels
{
    public class TeacherMap : ClassMap<Teacher>
    {
        public TeacherMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Gender);
            Map(x => x.Location);
            References(x => x.School);
            HasMany(x => x.Subjects);

            //HasMany(x => x.Subjects).Inverse().Cascade.All();
            //HasMany(x => x.SchoolClasses).Inverse().Cascade.All();
        }
    }
}
