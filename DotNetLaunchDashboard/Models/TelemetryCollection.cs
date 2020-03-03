using System.Collections.Generic;

namespace DotNetLaunchDashboard.Models
{
    public class TelemetryCollection<T>
    {
        public int Stage { get; set; }
        public IEnumerable<T> Telemetry { get; set; }
    }
}
