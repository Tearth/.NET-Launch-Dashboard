using DotNetLaunchDashboard.Models.Responses;

namespace DotNetLaunchDashboard.Builders.EndpointBuilders
{
    public class LaunchesBuilder : TelemetryParametersBuilderBase<AnalysedResponse>
    {
        protected override string Endpoint { get; set; } = "launches";

        public LaunchesBuilder(string company) : base(company)
        {

        }
    }
}