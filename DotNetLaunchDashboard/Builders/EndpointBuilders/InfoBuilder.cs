using DotNetLaunchDashboard.Models.Responses;

namespace DotNetLaunchDashboard.Builders.EndpointBuilders
{
    public class InfoBuilder : BuilderBase<InfoResponse>
    {
        protected override string Endpoint { get; set; } = "";

        public InfoBuilder() : base(string.Empty)
        {

        }
    }
}