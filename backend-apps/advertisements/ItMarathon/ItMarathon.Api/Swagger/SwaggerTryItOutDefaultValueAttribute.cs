namespace ItMarathon.Api.Swagger
{
    /// <summary>
    /// Endpoint parameter attribute for define a default value for Swagger.
    /// </summary>
    /// <param name="value">Default value to be used in "Try it out" in Swagger.</param>
    [AttributeUsage(AttributeTargets.Parameter)]
    public class SwaggerTryItOutDefaultValueAttribute(string value) : Attribute
    {
        /// <summary>
        /// Default value to be used in "Try it out" in Swagger.
        /// </summary>
        public string Value { get; } = value;
    }
}
