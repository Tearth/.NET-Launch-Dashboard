using System.Net.Http;
using DotNetLaunchDashboard.Models.Responses;

namespace DotNetLaunchDashboard.Builders.EndpointBuilders
{
    public class EventsBuilder : MissionParametersBuilderBase<EventsResponse>
    {
        protected override string Endpoint { get; set; } = "events";

        public EventsBuilder(HttpClient httpClient, string company) : base(httpClient, company)
        {

        }
    }
}