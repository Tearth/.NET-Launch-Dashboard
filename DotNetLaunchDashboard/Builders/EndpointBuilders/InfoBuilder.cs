using System.Net.Http;
using DotNetLaunchDashboard.Models.Responses;

namespace DotNetLaunchDashboard.Builders.EndpointBuilders
{
    public class InfoBuilder : BuilderBase<InfoResponse>
    {
        protected override string Endpoint { get; set; } = "";

        public InfoBuilder(HttpClient httpClient) : base(httpClient, string.Empty)
        {

        }
    }
}