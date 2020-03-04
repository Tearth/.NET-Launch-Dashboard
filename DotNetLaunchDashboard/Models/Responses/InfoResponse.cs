using Newtonsoft.Json;

namespace DotNetLaunchDashboard.Models.Responses
{
    /// <summary>
    /// Represents data returned from the "info" endpoint.
    /// </summary>
    public class InfoResponse
    {
        [JsonProperty("project_name")]
        public string ProjectName { get; set; }

        public string Version { get; set; }

        [JsonProperty("project_link")]
        public string ProjectLink { get; set; }

        public string Docs { get; set; }
        public string Organization { get; set; }

        [JsonProperty("organization_link")]
        public string OrganizationLink { get; set; }

        public string Description { get; set; }
    }
}
