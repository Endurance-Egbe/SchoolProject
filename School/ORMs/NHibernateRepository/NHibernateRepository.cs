using NHibernate;
using School.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMs.NHibernateRepository
{
    public class NHibernateRepository<T> : IRepository<T>
    {
        ISessionFactory SessionFactory { get; set; }
        public NHibernateRepository(ISessionFactoryCreation dataBase)
        {
            SessionFactory = dataBase.IsessionFactoryCreation();
        }
        public void CreateModel(T model)
        {
            using (var openSessionFactory = SessionFactory.OpenSession())
            {
                using (var transaction = openSessionFactory.BeginTransaction())
                {
                    openSessionFactory.Save(model);
                    transaction.Commit();
                }
            }

        }

        public void DeleteModel(T Model)
        {
            using (var openSessionFactory = SessionFactory.OpenSession())
            {
                using (var transaction = openSessionFactory.BeginTransaction())
                {
                    openSessionFactory.Delete(Model);
                    transaction.Commit();
                }
            }
        }

        public T GetModel(int id)
        {
            T model;
            using (var openSessionFactory = SessionFactory.OpenSession())
            {
                using (var transaction = openSessionFactory.BeginTransaction())
                {
                    model = openSessionFactory.Get<T>(id);
                    transaction.Commit();
                }
            }
            return model;
        }

        public void UpdateModel(T Model)
        {
            using (var openSessionFactory = SessionFactory.OpenSession())
            {
                using (var transaction = openSessionFactory.BeginTransaction())
                {
                    openSessionFactory.Update(Model);
                    transaction.Commit();
                }
            }
        }
    }
}
