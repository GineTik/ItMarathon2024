using System.Diagnostics.CodeAnalysis;

namespace ItMarathon.Api.Configuration;

[ExcludeFromCodeCoverage]
internal class AzureBlobStorageConfig
{
    public string ConnectionString { get; set; } = null!;

    public string ContainerName { get; set; } = null!;

    public string BaseUrl { get; set; } = null!;
}