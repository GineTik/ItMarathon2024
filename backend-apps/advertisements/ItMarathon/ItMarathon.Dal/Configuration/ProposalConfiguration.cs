using ItMarathon.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace ItMarathon.Dal.Configuration;

[ExcludeFromCodeCoverage]
public class ProposalConfiguration : IEntityTypeConfiguration<Proposal>
{
    public void Configure(EntityTypeBuilder<Proposal> builder)
    {
        builder.HasMany(pr => pr.Properties)
             .WithOne(p => p.Proposal)
             .HasForeignKey(p => p.ProposalId)
             .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(p => p.Price);
        builder.HasIndex(p => p.Location);
    }
}
