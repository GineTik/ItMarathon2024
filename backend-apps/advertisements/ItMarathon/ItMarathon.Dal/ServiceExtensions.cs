using ItMarathon.Dal.Common.Contracts;
using ItMarathon.Dal.Context;
using ItMarathon.Dal.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ItMarathon.Dal;

public static class ServiceExtensions
{
    public static void ConfigureDal(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySql(configuration.GetConnectionString(ApplicationDbContext.ConnectionString),
                new MySqlServerVersion(new Version(8, 0, 39)),
                mySqlOptions => mySqlOptions.MigrationsAssembly("ItMarathon.Dal")));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<IAppUserRepository, AppUserRepository>();
        services.AddScoped<IPropertyDefinitionRepository, PropertyDefinitionRepository>();
        services.AddScoped<IPropertyRepository, PropertyRepository>();
        services.AddScoped<IPropertyValueRepository, PropertyValueRepository>();
        services.AddScoped<IProposalRepository, ProposalRepository>();
        services.AddScoped<IProposalPhotoRepository, ProposalPhotoRepository>();
        services.AddScoped<IRequestRepository, RequestRepository>();
    }
}
