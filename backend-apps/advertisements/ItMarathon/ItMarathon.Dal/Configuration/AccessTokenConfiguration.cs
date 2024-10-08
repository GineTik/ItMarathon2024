using ItMarathon.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.CodeAnalysis;

namespace ItMarathon.Dal.Configuration;

[ExcludeFromCodeCoverage]
public class AccessTokenConfiguration : IEntityTypeConfiguration<AccessToken>
{
    public void Configure(EntityTypeBuilder<AccessToken> builder)
    {
        builder.HasOne(at => at.User)
            .WithMany(u => u.AccessTokens)
            .HasForeignKey(e => e.UserId)
            .HasConstraintName("fk_access_tokens_user_id_users")
            .OnDelete(DeleteBehavior.Cascade);
    }
}
