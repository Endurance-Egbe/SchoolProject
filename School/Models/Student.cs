using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Gender { get; set; }
        public virtual string Location { get; set; }
        public virtual SchoolModel School { get; set; }
        public virtual SchoolClass SchoolClass { get; set; }
        public virtual IList<Subject> Subjects { get; set; }
        
    }

}
