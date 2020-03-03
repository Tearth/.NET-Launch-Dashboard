using Newtonsoft.Json;

namespace DotNetLaunchDashboard.Models
{
    public abstract class MissionHeaderModel
    {
        [JsonProperty("mission_id")]
        public string MissionId { get; set; }

        public string Name { get; set; }

        [JsonProperty("flight_number")]
        public int FlightNumber { get; set; }

        [JsonProperty("launch_library_id")]
        public int LaunchLibraryId { get; set; }
    }
}
