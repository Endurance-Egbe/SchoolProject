using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMs.NHibernateRepository
{
    public interface ISessionFactoryCreation
    {
        ISessionFactory IsessionFactoryCreation();
    }
}
