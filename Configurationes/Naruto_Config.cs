using EF_SQL_Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_SQL_Server.Configurationes
{
  public class Naruto_Config : IEntityTypeConfiguration<Naruto>
  {
    public void Configure(EntityTypeBuilder<Naruto> builder)
    {
      builder.HasKey(n => n.Id);
      builder.Property(n => n.Name).HasMaxLength(50);
    }
  }
}
