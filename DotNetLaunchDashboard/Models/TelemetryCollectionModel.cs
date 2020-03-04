using System.Collections.Generic;

namespace DotNetLaunchDashboard.Models
{
    public class TelemetryCollectionModel<T>
    {
        /// <summary>
        /// Stage number.
        /// </summary>
        public int Stage { get; set; }

        /// <summary>
        /// Array of all collected telemetry data.
        /// </summary>
        public IEnumerable<T> Telemetry { get; set; }
    }
}
