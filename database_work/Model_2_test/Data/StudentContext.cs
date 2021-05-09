using Microsoft.EntityFrameworkCore;
using Model_2_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model_2_test.Data
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Major> Major { get; set; }
        public DbSet<StudentEnrollment> StudentEnrollment { get; set; }
    }
}
