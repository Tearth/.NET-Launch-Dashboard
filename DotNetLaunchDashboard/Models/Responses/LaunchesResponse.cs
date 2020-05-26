using System.Collections.Generic;

namespace DotNetLaunchDashboard.Models.Responses
{
    /// <summary>
    /// Represents data returned from the "launches" endpoint.
    /// </summary>
    public class LaunchesResponse : MissionHeaderModel
    {
        /// <summary>
        /// Raw telemetry collected from the launch stream.
        /// </summary>
        public IEnumerable<TelemetryCollectionModel<TelemetryChunkModel>> Raw { get; set; }

        /// <summary>
        /// Analysed telemetry containing additional data (compared to raw).
        /// </summary>
        public IEnumerable<TelemetryCollectionModel<AnalysedTelemetryChunkModel>> Analysed { get; set; }

        /// <summary>
        /// List of events that occurred during launch.
        /// </summary>
        public IEnumerable<EventModel> Events { get; set; }
    }
}
