using System.ComponentModel.DataAnnotations.Schema;

namespace notationRestApi.Models;

[Table("comments")]
public class Comment
{
    
    public int Id { get; set; }
    public User? User { get; set; }
    public Post? Post { get; set; }
}