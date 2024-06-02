
using Microsoft.EntityFrameworkCore;
namespace TodoList.Models
{
    public class TodoContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //seed data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "work", Name = "Work " },
                new Category { CategoryId = "home", Name = "home " },
                new Category { CategoryId = "ex", Name = "Exercise " },
                new Category { CategoryId = "shop", Name = "shopping " },
                new Category { CategoryId = "call", Name = "contact " }
            );

            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "open", StatusName = "open" },
                new Status { StatusId = "closed", StatusName = "Complete" }
                );
        }
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }
        public DbSet<Todo> Todos { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;
        
        
    }
}
