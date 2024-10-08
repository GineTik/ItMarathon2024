using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using ItMarathon.Api.Common.Contracts;
using ItMarathon.Api.Configuration;
using Microsoft.Extensions.Options;
using System.Net.Mime;

namespace ItMarathon.Api.Services;

internal class AzureBlobService(IOptions<AzureBlobStorageConfig> blobStorageConfig) : IAzureBlobService
{
    public async Task<string> UploadImageAsync(string base64Image)
    {
        if (base64Image.StartsWith("data:image"))
        {
            var base64Data = base64Image.Split(',')[1];
            base64Image = base64Data;
        }

        string fileName = $"{Guid.NewGuid()}.jpg";
        var blobContainerClient = GetBlobContainerClient();
        var blobClient = blobContainerClient.GetBlobClient(fileName);

        byte[] imageBytes = Convert.FromBase64String(base64Image);

        using var memStream = new MemoryStream(imageBytes, writable: false);

        var blobHttpHeaders = new BlobHttpHeaders
        {
            ContentType = MediaTypeNames.Image.Jpeg
        };

        await blobClient.UploadAsync(memStream, new BlobUploadOptions
        {
            HttpHeaders = blobHttpHeaders
        });

        return blobClient.Uri.ToString();
    }

    public async Task DeleteImageAsync(string blobUrl)
    {
        Uri uri = new Uri(blobUrl);
        string blobName = uri.Segments[uri.Segments.Length - 1];

        var blobContainerClient = GetBlobContainerClient();
        var blobClient = blobContainerClient.GetBlobClient(blobName);

        await blobClient.DeleteIfExistsAsync();
    }

    private BlobContainerClient GetBlobContainerClient(string containerName = null!)
    {
        var blobServiceClient = new BlobServiceClient(blobStorageConfig.Value.ConnectionString);
        containerName ??= blobStorageConfig.Value.ContainerName;

        try
        {
            blobServiceClient.CreateBlobContainer(containerName, publicAccessType: PublicAccessType.Blob);
        }
        catch
        {
            // Do nothing
        }

        var blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);
        return blobContainerClient;
    }
}
