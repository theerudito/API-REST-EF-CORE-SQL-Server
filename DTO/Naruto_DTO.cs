using EF_SQL_Server.Models;
using System.ComponentModel.DataAnnotations;

namespace EF_SQL_Server.DTO
{
    public class Naruto_DTO
    {
        [StringLength(maximumLength: 150)]
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        [StringLength(maximumLength: 150)]
        public string Clan { get; set; } = null!;
        public List<int> Jutsus { get; set; } = new List<int>();
    }
}
