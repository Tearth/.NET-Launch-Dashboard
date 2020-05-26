namespace DotNetLaunchDashboard.Models
{
    /// <summary>
    /// Represents single measurement.
    /// </summary>
    public class TelemetryChunkModel
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
    }
}
