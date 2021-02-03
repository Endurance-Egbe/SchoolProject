using FluentNHibernate.Mapping;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMs.NHibernateRepository.MapModels
{
    public class PrincipalMap : ClassMap<Principal>
    {
        public PrincipalMap()
        {
            Id(x => x.Id);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Map(x => x.Location);
            Map(x => x.Gender);
        }
    }
}
