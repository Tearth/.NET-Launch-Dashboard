using DotNetLaunchDashboard.Models.Responses;

namespace DotNetLaunchDashboard.Builders.EndpointBuilders
{
    public class AnalysedBuilder : TelemetryParametersBuilderBase<AnalysedResponse>
    {
        protected override string Endpoint { get; set; } = "analysed";

        public AnalysedBuilder(string company) : base(company)
        {

        }
    }
}
