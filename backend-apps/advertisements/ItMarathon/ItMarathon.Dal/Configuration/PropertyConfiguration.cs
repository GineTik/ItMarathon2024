using ItMarathon.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace ItMarathon.Dal.Configuration;

[ExcludeFromCodeCoverage]
public class PropertyConfiguration : IEntityTypeConfiguration<Property>
{
    public void Configure(EntityTypeBuilder<Property> builder)
    {
        builder.HasIndex(p => p.PredefinedValueId).IsUnique(false);
        builder.HasIndex(p => p.CustomValue);

        builder.ToTable(tableBuilder =>
        {
            tableBuilder.HasCheckConstraint("CK_Property_ProposalId_RequestId", "ProposalId IS NOT NULL OR RequestId IS NOT NULL");
        });
    }
}
