using Microsoft.EntityFrameworkCore;

namespace todo_asp.net.Models
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; } = null!;

        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }
    }
}
