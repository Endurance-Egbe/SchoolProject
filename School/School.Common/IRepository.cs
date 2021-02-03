using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Common
{
    public interface IRepository<T>
    {
        void CreateModel(T model);
        T GetModel(int id);
        void UpdateModel(T Model);
        void DeleteModel(T Model);
    }

}
