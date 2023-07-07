using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models;

[Table("Tag")]
public class Tag
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Slug { get; set; }
}