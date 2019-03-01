using Microsoft.EntityFrameworkCore;

using MyFirstEFCoreProject.Model;

namespace MyFirstEFCoreProject.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source=todo.db");
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Todo> Todos { get; set; }
    }
}