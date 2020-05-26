using Newtonsoft.Json;

namespace DotNetLaunchDashboard.Models.Responses
{
    /// <summary>
    /// Represents data returned from the "info" endpoint.
    /// </summary>
    public class InfoResponse
    {
        /// <summary>
        /// API name.
        /// </summary>
        [JsonProperty("project_name")]
        public string ProjectName { get; set; }

        /// <summary>
        /// API version.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Link to the API website.
        /// </summary>
        [JsonProperty("project_link")]
        public string ProjectLink { get; set; }

        /// <summary>
        /// Link to the API documentation.
        /// </summary>
        public string Docs { get; set; }

        /// <summary>
        /// Name of the organization which owns the API.
        /// </summary>
        public string Organization { get; set; }

        /// <summary>
        /// Link to the organization website which owns the API.
        /// </summary>
        [JsonProperty("organization_link")]
        public string OrganizationLink { get; set; }

        /// <summary>
        /// Description of the API.
        /// </summary>
        public string Description { get; set; }
    }
}
