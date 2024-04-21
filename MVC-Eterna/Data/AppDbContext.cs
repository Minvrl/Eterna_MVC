using Microsoft.EntityFrameworkCore;
using MVC_Eterna.Models;

namespace MVC_Eterna.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectImg> ProjectImgs { get; set; }
        public DbSet<SliderItem> SliderItems { get; set; }  

    }
}
