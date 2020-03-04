using System.Net.Http;
using DotNetLaunchDashboard.Models.Responses;

namespace DotNetLaunchDashboard.Builders.EndpointBuilders
{
    /// <summary>
    /// Query builder for the "Analysed" endpoint.
    /// </summary>
    public class AnalysedBuilder : TelemetryParametersBuilderBase<AnalysedResponse>
    {
        /// <inheritdoc />
        protected override string Endpoint { get; set; } = "analysed";

        /// <summary>
        /// Initializes a new instance of the <see cref="AnalysedBuilder"/> class.
        /// </summary>
        /// <param name="httpClient">HTTP client which will be used to communication with the API.</param>
        /// <param name="company">Company name for which requested data belongs.</param>
        public AnalysedBuilder(HttpClient httpClient, string company) : base(httpClient, company)
        {

        }
    }
}
