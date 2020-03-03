using Newtonsoft.Json;

namespace DotNetLaunchDashboard.Models
{
    public class AnalysedTelemetryChunkModel
    {
        public float Time { get; set; }
        public float Velocity { get; set; }
        public float Altitude { get; set; }

        [JsonProperty("velocity_x")]
        public float VelocityX { get; set; }

        [JsonProperty("velocity_y")]
        public float VelocityY { get; set; }

        public float Acceleration { get; set; }

        [JsonProperty("downrange_distance")]
        public float DownrangeDistance { get; set; }

        public float Angle { get; set; }
        public float Q { get; set; }
    }
}
