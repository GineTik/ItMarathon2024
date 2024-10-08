using ItMarathon.Api.Common;
using ItMarathon.Api.Common.Contracts;
using ItMarathon.Api.Configuration;
using ItMarathon.Api.Middlewares;
using ItMarathon.Api.Services;
using ItMarathon.Api.Swagger;
using ItMarathon.Dal;
using ItMarathon.Dal.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.OData;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateBootstrapLogger();

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services
        .AddControllers()
        .AddJsonOptions(opts =>
        {
            opts.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            opts.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
        })
        .AddOData(opts =>
        {
            opts
                .Select()
                .Expand()
                .Filter()
                .Count()
                .OrderBy()
                .SetMaxTop(1000);
        });

    builder.Services.AddAutoMapper(typeof(Program));
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.ConfigureDal(builder.Configuration);

    builder.Services.AddScoped<IAzureBlobService, AzureBlobService>();
    builder.Services.AddScoped<IProposalService, ProposalService>();
    builder.Services.AddScoped<IPropertyDefinitionService, PropertyDefinitionService>();
    builder.Services.Configure<AzureBlobStorageConfig>(builder.Configuration.GetSection(nameof(AzureBlobStorageConfig)));

    builder.Services.AddAuthentication()
        .AddBearerToken();
    builder.Services.AddAuthorizationBuilder()
        .AddPolicy(Consts.Authorization.SuperUserPolicy, policy => 
        {
            policy.RequireClaim(Consts.Authorization.IsSuperUserClaim, "True");
        });

    // Configure swagger
    builder.Services.AddSwaggerGen(options =>
    {
        options.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "IT Marathon v4",
            Description = "Pets adoption application",
            Version = Assembly.GetExecutingAssembly().GetName().Version!.ToString(3),
        });

        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        options.IncludeXmlComments(xmlPath, true);
        options.SchemaFilter<SwaggerTryItOutDefaultValue>();

        options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
        {
            In = ParameterLocation.Header,
            Description = "Please enter token",
            Name = "Authorization",
            Type = SecuritySchemeType.Http,
            BearerFormat = "JWT",
            Scheme = "bearer"
        });

        options.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type=ReferenceType.SecurityScheme,
                        Id="Bearer"
                    }
                },
                Array.Empty<string>()
            }
        });
    });

    builder.Host.UseSerilog((hostingContext, loggerConfiguration) => 
        loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration));

    var app = builder.Build();


    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();
    app.UseMiddleware<AuthorizationMiddleware>();
    app.UseAuthentication();
    app.UseAuthorization();
    app.MapControllers();

    using (var scope = app.Services.CreateScope())
    {
        var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        await context.Database.MigrateAsync();
    }

    app.Run();
}
catch(Exception ex)
{
    Log.Fatal(ex, "Application terminated unexpectedly");
}
finally
{
    Log.CloseAndFlush();
}