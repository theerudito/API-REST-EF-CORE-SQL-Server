using EF_SQL_Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_SQL_Server.Configurationes
{
  public class Jutsu_Config : IEntityTypeConfiguration<Jutsu>
  {
    public void Configure(EntityTypeBuilder<Jutsu> builder)
    {
      builder.HasKey(j => j.Id);
      builder.Property(j => j.Name).HasMaxLength(100);
    }
  }
}
