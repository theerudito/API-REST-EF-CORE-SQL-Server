using System.ComponentModel.DataAnnotations;

namespace EF_SQL_Server.Models
{
  public class Jutsu
  {
    [Key]
    public int Id { get; set; }
    [StringLength(maximumLength: 150)]
    public string Name { get; set; } = null!;
    public int NarutoId { get; set; }
    public Naruto Naruto { get; set; } = null!;
  }
}
