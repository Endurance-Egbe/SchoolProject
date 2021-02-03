using School.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMs.EFCoreRepository
{
    public class EFCoreRepository<T> : IRepository<T> where T : class
    {
        private ADBContext schoolContext;
        public EFCoreRepository(ADBContext sqlType)
        {
            schoolContext = sqlType;
        }
        public void CreateModel(T model)
        {
            schoolContext.Add(model);
            schoolContext.SaveChanges();
        }

        public void DeleteModel(T model)
        {
            schoolContext.Remove(model);
            schoolContext.SaveChanges();
        }

        public T GetModel(int id)
        {

            T model = schoolContext.Find<T>(id);

            return model;
        }

        public void UpdateModel(T model)
        {
            schoolContext.Update(model);
            schoolContext.SaveChanges();
        }

    }

}
