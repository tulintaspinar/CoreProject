using CoreProject.API.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace CoreProject.API.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-5CE3LGO;Database=UdemyDbCoreProject2;Integrated Security=True;");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
