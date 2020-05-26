using System.Net.Http;
using DotNetLaunchDashboard.Models.Responses;

namespace DotNetLaunchDashboard.Builders.EndpointBuilders
{
    /// <summary>
    /// Query builder for the "Info" endpoint.
    /// </summary>
    public class InfoBuilder : BuilderBase<InfoResponse>
    {
        /// <inheritdoc />
        protected override string Endpoint { get; set; } = "";

        /// <summary>
        /// Initializes a new instance of the <see cref="InfoBuilder"/> class.
        /// </summary>
        /// <param name="httpClient">HTTP client which will be used to communication with the API.</param>
        public InfoBuilder(HttpClient httpClient) : base(httpClient, string.Empty)
        {

        }
    }
}