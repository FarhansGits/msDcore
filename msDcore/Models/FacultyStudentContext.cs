using Microsoft.EntityFrameworkCore;

namespace msDcore.Models
{
    public class FacultyStudentContext:DbContext
    {
        public FacultyStudentContext(DbContextOptions<FacultyStudentContext> options) : base(options)
        {

        }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
