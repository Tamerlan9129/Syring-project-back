using Microsoft.EntityFrameworkCore;
using Syring_project.Models;

namespace Syring_project.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<AssociatedDoctorsComponent> DoctorsComponents { get; set; }
        public DbSet<DepartmentComponent> DepartmentComponents { get; set; }

        public DbSet<Category>Categories { get; set; }

        public DbSet<CategoryComponent> CategoryComponents { get; set; }
    }
}
