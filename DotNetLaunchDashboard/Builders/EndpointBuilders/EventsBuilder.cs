using DotNetLaunchDashboard.Models.Responses;

namespace DotNetLaunchDashboard.Builders.EndpointBuilders
{
    public class EventsBuilder : TelemetryParametersBuilderBase<EventsResponse>
    {
        protected override string Endpoint { get; set; } = "events";

        public EventsBuilder(string company) : base(company)
        {

        }
    }
}