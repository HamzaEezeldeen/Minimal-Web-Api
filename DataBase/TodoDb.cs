using Microsoft.EntityFrameworkCore;
using Minimal_Web_Api.Models;

namespace Minimal_Web_Api.DataBase;

public class TodoDb : DbContext
{
    public TodoDb(DbContextOptions<TodoDb> options)
      : base(options) { }

    public DbSet<Todo> Todos => Set<Todo>();
}
