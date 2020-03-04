using System.Net.Http;
using DotNetLaunchDashboard.Models.Responses;

namespace DotNetLaunchDashboard.Builders.EndpointBuilders
{
    public class LaunchesBuilder : TelemetryParametersBuilderBase<LaunchesResponse>
    {
        protected override string Endpoint { get; set; } = "launches";

        public LaunchesBuilder(HttpClient httpClient, string company) : base(httpClient, company)
        {

        }
    }
}