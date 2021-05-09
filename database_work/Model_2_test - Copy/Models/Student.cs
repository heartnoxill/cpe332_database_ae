using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model_2_test.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string StudentName { get; set; }
        public virtual ICollection<StudentEnrollment> StudentEnrollments { get; set; }
    }
}
