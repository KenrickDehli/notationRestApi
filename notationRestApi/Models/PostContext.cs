using Microsoft.EntityFrameworkCore;

namespace notationRestApi.Models;

public class PostContext : DbContext
{
    
    public PostContext(DbContextOptions<UserContext> options) : base(options)
    {
        
    }

    public DbSet<Post> Posts { get; set; }
}