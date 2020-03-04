using System.Collections.Generic;

namespace DotNetLaunchDashboard.Models.Responses
{
    /// <summary>
    /// Represents data returned from the "launches" endpoint.
    /// </summary>
    public class LaunchesResponse : MissionHeaderModel
    {
        public IEnumerable<TelemetryCollectionModel<TelemetryChunkModel>> Raw { get; set; }
        public IEnumerable<TelemetryCollectionModel<AnalysedTelemetryChunkModel>> Analysed { get; set; }
        public IEnumerable<EventModel> Events { get; set; }
    }
}
