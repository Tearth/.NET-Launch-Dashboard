using System.Collections.Generic;

namespace DotNetLaunchDashboard.Models.Responses
{
    public class LaunchesResponse : MissionHeaderModel
    {
        public IEnumerable<TelemetryCollection<TelemetryChunkModel>> Raw { get; set; }
        public IEnumerable<TelemetryCollection<AnalysedTelemetryChunkModel>> Analysed { get; set; }
        public IEnumerable<EventModel> Events { get; set; }
    }
}
