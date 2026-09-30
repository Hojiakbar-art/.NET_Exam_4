using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class OrganizerConfiguration : IEntityTypeConfiguration<Organizer>
{
    public void Configure(EntityTypeBuilder<Organizer> builder)
    {
        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.CompanyName)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(x=>x.ContactEmail)
            .IsRequired()
            .HasMaxLength(100);
        builder.Property(x=>x.Phone)
            .HasMaxLength(50);
        builder.HasMany(x=>x.Events)
            .WithOne(x=>x.Organizer)
            .HasForeignKey(x=>x.OrganizerId);
    }
}