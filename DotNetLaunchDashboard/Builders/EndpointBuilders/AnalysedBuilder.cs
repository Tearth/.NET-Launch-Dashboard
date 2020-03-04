using System.Net.Http;
using DotNetLaunchDashboard.Models.Responses;

namespace DotNetLaunchDashboard.Builders.EndpointBuilders
{
    public class AnalysedBuilder : TelemetryParametersBuilderBase<AnalysedResponse>
    {
        protected override string Endpoint { get; set; } = "analysed";

        public AnalysedBuilder(HttpClient httpClient, string company) : base(httpClient, company)
        {

        }
    }
}
