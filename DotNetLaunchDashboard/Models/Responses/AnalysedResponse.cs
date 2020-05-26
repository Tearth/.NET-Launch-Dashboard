using System.Collections.Generic;

namespace DotNetLaunchDashboard.Models.Responses
{
    /// <summary>
    /// Represents data returned from the "analyzed" endpoint.
    /// </summary>
    public class AnalysedResponse : List<TelemetryCollectionModel<AnalysedTelemetryChunkModel>>
    {
        
    }
}
