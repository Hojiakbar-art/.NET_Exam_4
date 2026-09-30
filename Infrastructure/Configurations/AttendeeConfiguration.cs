using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
public class AttendeeConfiguration: IEntityTypeConfiguration<Attendee>
{
    public void Configure(EntityTypeBuilder<Attendee> entity)
    {
        entity.ToTable("attendees");
        entity.HasKey(x=>x.Id);
        entity.Property(x=>x.FullName)
            .IsRequired()
            .HasMaxLength(100);
        entity.Property(x=>x.Email)
            .IsRequired()
            .HasMaxLength(100);
        
    }
}
