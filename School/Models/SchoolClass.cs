using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class SchoolClass
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual String Name { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual SchoolModel School { get; set; }
        public virtual IList<Subject> Subjects { get; set; }
        public virtual IList<Student> Students { get; set; }
        
    }

}
