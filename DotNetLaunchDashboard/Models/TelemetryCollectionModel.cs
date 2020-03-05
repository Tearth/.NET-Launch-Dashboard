using System.Collections.Generic;

namespace DotNetLaunchDashboard.Models
{
    /// <summary>
    /// Represents wrapper for the telemetry measurements and stage number.
    /// </summary>
    /// <typeparam name="T">Type of the measurement.</typeparam>
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
