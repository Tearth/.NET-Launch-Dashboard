using System.Net.Http;
using DotNetLaunchDashboard.Models.Responses;

namespace DotNetLaunchDashboard.Builders.EndpointBuilders
{
    public class RawBuilder : TelemetryParametersBuilderBase<RawResponse>
    {
        protected override string Endpoint { get; set; } = "raw";

        public RawBuilder(HttpClient httpClient, string company) : base(httpClient, company)
        {

        }
    }
}