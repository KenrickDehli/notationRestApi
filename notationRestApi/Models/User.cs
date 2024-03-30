using System.ComponentModel.DataAnnotations.Schema;

namespace notationRestApi.Models;

[Table("users")]
public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
}