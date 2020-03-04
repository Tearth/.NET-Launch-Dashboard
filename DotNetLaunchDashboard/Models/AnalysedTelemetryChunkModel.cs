using Newtonsoft.Json;

namespace DotNetLaunchDashboard.Models
{
    public class AnalysedTelemetryChunkModel
    {
        /// <summary>
        /// Time since launch (in seconds).
        /// </summary>
        public float Time { get; set; }

        /// <summary>
        /// Velocity of the rocket.
        /// </summary>
        public float Velocity { get; set; }

        /// <summary>
        /// Altitude of the rocket.
        /// </summary>
        public float Altitude { get; set; }

        /// <summary>
        /// The vertical component of the velocity.
        /// </summary>
        [JsonProperty("velocity_x")]
        public float VelocityX { get; set; }

        /// <summary>
        /// The horizontal component of the velocity.
        /// </summary>
        [JsonProperty("velocity_y")]
        public float VelocityY { get; set; }

        /// <summary>
        /// The acceleration of the rocket (without gravitational acceleration).
        /// </summary>
        public float Acceleration { get; set; }

        /// <summary>
        /// The rocket's distance from the launch pad.
        /// </summary>
        [JsonProperty("downrange_distance")]
        public float DownrangeDistance { get; set; }

        /// <summary>
        /// The velocity vector's angle (to the horizon).
        /// </summary>
        public float Angle { get; set; }

        /// <summary>
        /// The aerodynamic pressure.
        /// </summary>
        public float Q { get; set; }
    }
}
