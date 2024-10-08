using ItMarathon.Dal.Entities;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;

namespace ItMarathon.Api.Utilities;

/// <summary>
/// Provides utility methods for working with OData in the application.
/// </summary>
public static class ODataUtility
{
    /// <summary>
    /// Creates an HttpRequest from HttpRequestMessage.
    /// </summary>
    /// <param name="requestMessage">The HttpRequestMessage.</param>
    /// <returns>The HttpRequest.</returns>
    public static HttpRequest CreateHttpRequest(HttpRequestMessage requestMessage)
    {
        var context = new DefaultHttpContext();
        context.Request.Method = requestMessage.Method.Method;
        context.Request.QueryString = new QueryString(requestMessage.RequestUri!.Query);
        return context.Request;
    }

    /// <summary>
    /// Gets the OData EDM model.
    /// </summary>
    /// <returns>The IEdmModel.</returns>
    public static IEdmModel GetEdmModel()
    {
        var modelBuilder = new ODataConventionModelBuilder();
        modelBuilder.AddEntityType(typeof(Proposal));

        return modelBuilder.GetEdmModel();
    }
}