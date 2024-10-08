namespace ItMarathon.Api.Common.Contracts;

/// <summary>
/// Provides functionality to interact with Azure Blob Storage for managing images.
/// </summary>
public interface IAzureBlobService
{
    /// <summary>
    /// Uploads an image to Azure Blob Storage.
    /// </summary>
    /// <param name="base64Image">The image content encoded as a base64 string.</param>
    /// <returns>A task resulting in the URL at which the uploaded image is accessible.</returns>
    Task<string> UploadImageAsync(string base64Image);

    /// <summary>
    /// Deletes an image from Azure Blob Storage.
    /// </summary>
    /// <param name="blobUrl">The full URL of the image in Azure Blob Storage to be deleted.</param>
    /// <returns>A task representing the asynchronous delete operation.</returns>
    Task DeleteImageAsync(string blobUrl);
}
