using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SchoolModel
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual String Name { get; set; }
        public virtual string Location { get; set; }
        public virtual Principal Principal { get; set; }
        public virtual IList<Teacher> Teachers { get; set; }
        public virtual IList<SchoolClass> SchoolClasses { get; set; }
        public virtual IList<Student> Students { get; set; }
        
    }

}
