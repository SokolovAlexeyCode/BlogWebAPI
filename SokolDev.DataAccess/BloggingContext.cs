using Microsoft.EntityFrameworkCore;
using SokolDev.DataAccess.Entities;

namespace SokolDev.DataAccess;

public class BloggingContext : DbContext
{
    public BloggingContext()
    {
        // I have commented that because I tried to use Migrations and "initialCreate"
        // base.Database.EnsureCreated();
    }

    // As you can see there is no Author DbSet, but it still maps to database as part of Blog entity
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Post> Posts { get; set; }

    public DbSet<UserAddress> UserAddresses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blog>().HasIndex(blog => new { blog.BlogId });
        modelBuilder.Entity<Post>().HasIndex(blog => new { blog.PostId }).HasDatabaseName("PostIdIndex");
        // Using fluent api for a behavior redefining 
        modelBuilder.Entity<UserAddress>().ToTable("Addresses");
        
        base.OnModelCreating(modelBuilder);
    }
}