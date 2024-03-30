using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace notationRestApi.Models;

[Table("posts")]
public class Post
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public User? User { get; set; }
    public Blob Pdf { get; set; } 
}