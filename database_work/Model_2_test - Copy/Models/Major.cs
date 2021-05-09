using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Model_2_test.Models
{
    public class Major
    {
        [Key]
        public int MajorID { get; set; }
        public string MajorTitle { get; set; }
        public virtual ICollection<StudentEnrollment> StudentEnrollments { get; set; }
    }
}
