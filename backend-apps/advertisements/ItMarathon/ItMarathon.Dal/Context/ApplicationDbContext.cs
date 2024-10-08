using ItMarathon.Dal.Configuration;
using ItMarathon.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace ItMarathon.Dal.Context;

public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
{
    public static string ConnectionString { get; set; } = "DefaultConnection";

    public DbSet<AccessToken> AccessTokens { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Property> Properties { get; set; }
    public DbSet<PropertyDefinition> PropertiesDefinition { get; set; }
    public DbSet<PropertyValue> PropertyValues { get; set; }
    public DbSet<Proposal> Proposals { get; set; }
    public DbSet<ProposalPhoto> ProposalsPhoto { get; set; }
    public DbSet<Request> Requests { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AccessTokenConfiguration());
        modelBuilder.ApplyConfiguration(new PropertyDefinitionConfiguration());
        modelBuilder.ApplyConfiguration(new PropertyValueConfiguration());
        modelBuilder.ApplyConfiguration(new PropertyConfiguration());
        modelBuilder.ApplyConfiguration(new ProposalConfiguration());
    }
}
