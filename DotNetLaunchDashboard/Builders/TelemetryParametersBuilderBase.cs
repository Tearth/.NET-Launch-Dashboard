using System.Net.Http;

namespace DotNetLaunchDashboard.Builders
{
    /// <summary>
    /// Base class for all query builders, with support for mission and telemetry parameters.
    /// </summary>
    /// <typeparam name="T">Type of the class, to which the API response will be deserialized.</typeparam>
    public abstract class TelemetryParametersBuilderBase<T> : MissionParametersBuilderBase<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TelemetryParametersBuilderBase{T}"/> class.
        /// </summary>
        /// <param name="httpClient">HTTP client which will be used to communication with the API.</param>
        /// <param name="company">Company name for which requested data belongs.</param>
        protected TelemetryParametersBuilderBase(HttpClient httpClient, string company) : base(httpClient, company)
        {

        }

        /// <summary>
        /// Sets start time of the returned telemetry.
        /// </summary>
        /// <param name="start">Start time of the returned telemetry.</param>
        /// <returns>Builder instance ready to execute or add new parameters.</returns>
        public MissionParametersBuilderBase<T> WithStart(int start)
        {
            AddParameter("start", start);
            return this;
        }

        /// <summary>
        /// Sets start event of the returned telemetry.
        /// </summary>
        /// <param name="start">Event name (eg. "meco").</param>
        /// <returns>Builder instance ready to execute or add new parameters.</returns>
        public MissionParametersBuilderBase<T> WithStart(string start)
        {
            AddParameter("start", start);
            return this;
        }

        /// <summary>
        /// Sets end time of the returned telemetry.
        /// </summary>
        /// <param name="end">End time of the returned telemetry.</param>
        /// <returns>Builder instance ready to execute or add new parameters.</returns>
        public MissionParametersBuilderBase<T> WithEnd(int end)
        {
            AddParameter("end", end);
            return this;
        }

        /// <summary>
        /// Sets end event of the returned telemetry.
        /// </summary>
        /// <param name="end">Event name (eg. "meco").</param>
        /// <returns>Builder instance ready to execute or add new parameters.</returns>
        public MissionParametersBuilderBase<T> WithEnd(string end)
        {
            AddParameter("end", end);
            return this;
        }

        /// <summary>
        /// Sets time offset which will be added to the "start" field (of the time at the event).
        /// </summary>
        /// <param name="startOffset">Time offset to apply.</param>
        /// <returns>Builder instance ready to execute or add new parameters.</returns>
        public MissionParametersBuilderBase<T> WithStartOffset(int startOffset)
        {
            AddParameter("start_offset", startOffset);
            return this;
        }

        /// <summary>
        /// Sets time offset which will be added to the "end" field (of the time at the event).
        /// </summary>
        /// <param name="endOffset">Time offset to apply.</param>
        /// <returns>Builder instance ready to execute or add new parameters.</returns>
        public MissionParametersBuilderBase<T> WithEndOffset(int endOffset)
        {
            AddParameter("end_offset", endOffset);
            return this;
        }

        /// <summary>
        /// Sets event for which the telemetry will be returned.
        /// </summary>
        /// <param name="event">Event name (eg. "meco").</param>
        /// <returns>Builder instance ready to execute or add new parameters.</returns>
        public MissionParametersBuilderBase<T> WithEvent(string @event)
        {
            AddParameter("event", @event);
            return this;
        }

        /// <summary>
        /// Sets time which will be added to the "event" field.
        /// </summary>
        /// <param name="eventOffset">Time offset to apply.</param>
        /// <returns>Builder instance ready to execute or add new parameters.</returns>
        public MissionParametersBuilderBase<T> WithEventOffset(int eventOffset)
        {
            AddParameter("event_offset", eventOffset);
            return this;
        }

        /// <summary>
        /// Sets frequency of the data points in the returned telemetry.
        /// </summary>
        /// <param name="frameRate">Frame rate to apply.</param>
        /// <returns>Builder instance ready to execute or add new parameters.</returns>
        public MissionParametersBuilderBase<T> WithFrameRate(int frameRate)
        {
            AddParameter("frame_rate", frameRate);
            return this;
        }

        /// <summary>
        /// Sets time between each data points in the returned telemetry.
        /// </summary>
        /// <param name="interval">Interval value to apply.</param>
        /// <returns>Builder instance ready to execute or add new parameters.</returns>
        public MissionParametersBuilderBase<T> WithInterval(int interval)
        {
            AddParameter("interval", interval);
            return this;
        }

        /// <summary>
        /// Sets stage for which the telemetry will be returned.
        /// </summary>
        /// <param name="stage">Stage number.</param>
        /// <returns>Builder instance ready to execute or add new parameters.</returns>
        public MissionParametersBuilderBase<T> WithStage(int stage)
        {
            AddParameter("stage", stage);
            return this;
        }
    }
}
