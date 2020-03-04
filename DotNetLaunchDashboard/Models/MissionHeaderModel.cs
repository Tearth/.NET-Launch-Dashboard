using Newtonsoft.Json;

namespace DotNetLaunchDashboard.Models
{
    public abstract class MissionHeaderModel
    {
        /// <summary>
        /// Name (identificator) of the mission.
        /// </summary>
        [JsonProperty("mission_id")]
        public string MissionId { get; set; }

        /// <summary>
        /// Full name of the mission.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Flight number from the launch provider's first flight.
        /// </summary>
        [JsonProperty("flight_number")]
        public int FlightNumber { get; set; }

        /// <summary>
        /// Internal API identificator.
        /// </summary>
        [JsonProperty("launch_library_id")]
        public int LaunchLibraryId { get; set; }
    }
}
