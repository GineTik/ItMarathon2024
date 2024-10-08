using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace ItMarathon.Api.Swagger
{
    /// <summary>
    /// Swagger schema filter for define a default value for a parameter.
    /// </summary>
    public class SwaggerTryItOutDefaultValue : ISchemaFilter
    {
        /// <summary>
        /// Apply is called for each parameter
        /// </summary>
        /// <param name="schema"></param>
        /// <param name="context"></param>
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (context.ParameterInfo != null)
            {
                var att = context.ParameterInfo.GetCustomAttribute<SwaggerTryItOutDefaultValueAttribute>();
                if (att != null)
                {
                    schema.Example = new Microsoft.OpenApi.Any.OpenApiString(att.Value.ToString());
                }
            }
        }
    }
}
