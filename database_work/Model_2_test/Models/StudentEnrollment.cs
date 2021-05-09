using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Model_2_test.Models
{
    public class StudentEnrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int MajorID { get; set; }
        public int StudentID { get; set; }
        public virtual Major Major { get; set; }
        public virtual Student Student { get; set; }
    }
}
