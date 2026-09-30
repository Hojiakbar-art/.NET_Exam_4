using System.Security.Cryptography.Xml;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.HasKey(x=>x.Id);
        builder.HasOne(x=>x.Attendee)
            .WithMany(x=>x.Tickets)
            .HasForeignKey(x=>x.AttendeeId);
        builder.HasOne(x=>x.TicketType)
            .WithMany(x=>x.Tickets)
            .HasForeignKey(x=>x.TicketTypeId);
        builder.HasOne(x=>x.Order)
            .WithMany(x=>x.Tickets)
            .HasForeignKey(x=>x.OrderId);
        builder.Property(x=>x.Code)
            .IsRequired();
        builder.Property(x=>x.Price)
            .IsRequired();
    }
}