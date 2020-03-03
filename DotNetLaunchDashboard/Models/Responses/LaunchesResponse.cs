using System.Collections.Generic;

namespace DotNetLaunchDashboard.Models.Responses
{
    public class LaunchesResponse : MissionHeaderModel
    {
        public TelemetryCollection<TelemetryChunkModel> Raw { get; set; }
        public TelemetryCollection<AnalysedTelemetryChunkModel> Analysed { get; set; }
        public IEnumerable<EventModel> Events { get; set; }
    }
}
