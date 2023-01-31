using System.ComponentModel.DataAnnotations;

namespace EF_SQL_Server.Models
{
  public class Naruto
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Age { get; set; }
    [StringLength(maximumLength: 150)]
    public string Clan { get; set; } = null!;
    // PARA ORDENAR
    public List<Jutsu> Jutsus { get; set; } = new List<Jutsu>();
    //public HashSet<Jutsu> Jutsus { get; set; } = new HashSet<Jutsu>();
  }
}
