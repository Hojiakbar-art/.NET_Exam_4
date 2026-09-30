using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class VenueConfiguration : IEntityTypeConfiguration<Venue>
{
    public void Configure(EntityTypeBuilder<Venue> builder)
    {
        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.Name)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(x=>x.Address)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(x=>x.City)
            .IsRequired()
            .HasMaxLength(100);
    }
}