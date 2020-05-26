using System.Net.Http;
using DotNetLaunchDashboard.Models.Responses;

namespace DotNetLaunchDashboard.Builders.EndpointBuilders
{
    /// <summary>
    /// Query builder for the "Events" endpoint.
    /// </summary>
    public class EventsBuilder : MissionParametersBuilderBase<EventsResponse>
    {
        /// <inheritdoc />
        protected override string Endpoint { get; set; } = "events";

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsBuilder"/> class.
        /// </summary>
        /// <param name="httpClient">HTTP client which will be used to communication with the API.</param>
        /// <param name="company">Company name for which requested data belongs.</param>
        public EventsBuilder(HttpClient httpClient, string company) : base(httpClient, company)
        {

        }
    }
}