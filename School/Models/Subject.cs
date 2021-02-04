using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Subject
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual SchoolClass SchoolClass { get; set; }
        public virtual IList<Student> Students { get; set; }
        
    }

}
