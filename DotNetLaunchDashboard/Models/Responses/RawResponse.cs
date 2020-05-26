using System.Collections.Generic;

namespace DotNetLaunchDashboard.Models.Responses
{
    /// <summary>
    /// Represents data returned from the "raw" endpoint.
    /// </summary>
    public class RawResponse : List<TelemetryCollectionModel<TelemetryChunkModel>>
    {

    }
}
