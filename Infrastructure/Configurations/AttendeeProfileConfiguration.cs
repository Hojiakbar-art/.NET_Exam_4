using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

public class AttendeeProfileConfiguration : IEntityTypeConfiguration<AttendeeProfile>
{
    public void Configure(EntityTypeBuilder<AttendeeProfile> builder)
    {
        builder.HasKey(x=>x.Id);
        builder.Property(x=>x.City)
            .HasMaxLength(100);
        builder.Property(x=>x.Bio)
            .HasMaxLength(100);
    }
}