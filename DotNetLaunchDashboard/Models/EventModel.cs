namespace DotNetLaunchDashboard.Models
{
    /// <summary>
    /// Represents single event.
    /// </summary>
    public class EventModel
    {
        /// <summary>
        /// Name of the event.
        /// </summary>
        public string Key { get; set; }
        
        /// <summary>
        /// Time of the event (in seconds).
        /// </summary>
        public float? Time { get; set; }
    }
}
