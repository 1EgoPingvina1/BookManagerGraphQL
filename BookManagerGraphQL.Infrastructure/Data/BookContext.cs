using BookManagerGraphQL.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookManagerGraphQL.Infrastructure.Data;

public class BookContext : DbContext
{
    public BookContext(DbContextOptions<BookContext> options) : base(options){}

    public DbSet<User> Users { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<Book> Books { get; set; }
    
    public DbSet<Message> Messages { get; set; }
    public DbSet<Reviews> Reviews { get; set; }
}