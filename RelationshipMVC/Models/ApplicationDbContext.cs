using Microsoft.EntityFrameworkCore;
using RelationshipMVC.Models.One_to_One_Mapping;

namespace RelationshipMVC.Models
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }

    }
}
