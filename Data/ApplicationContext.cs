using Microsoft.EntityFrameworkCore;
using StudentManagement.Models.DepartmentModels;
using StudentManagement.Models.StudentModels;

namespace StudentManagement.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) {
        
        
        
        
        
        }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Database=StudentInfoDB; Username=postgres; Password=123");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
           .HasKey(d => d.DepartmentID); // Primary key configuration

            // Configure relationships if needed
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Students)
                .WithOne(s => s.Department)
                .HasForeignKey(s => s.DepartmentID);

            
            base.OnModelCreating(modelBuilder);

        }
        public DbSet<Department> Department { get; set; }
        public DbSet<Student> Student { get; set; }
       
    }
}
