namespace DotNetLaunchDashboard.Models.Responses
{
    public class AnalysedResponse : MissionHeaderModel
    {
        public TelemetryCollection<AnalysedTelemetryChunkModel> Analysed;
    }
}
