using Microsoft.EntityFrameworkCore;

namespace notationRestApi.Models;

public class CommentContext : DbContext
{
    
    public CommentContext(DbContextOptions<UserContext> options) : base(options)
    {
        
    }

    public DbSet<Comment> Comments { get; set; }
}