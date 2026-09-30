using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(x=>x.Id);
        builder.HasMany(x=>x.Tickets)
            .WithOne(x=>x.Order)
            .HasForeignKey(x=>x.OrderId);
        builder.HasOne(x=>x.Attendee)
            .WithMany(x=>x.Orders)
            .HasForeignKey(x=>x.AttendeeId);
        builder.Property(x=>x.AttendeeId)
            .IsRequired();
        builder.Property(x=>x.TotalAmount)
            .IsRequired();
    }
}