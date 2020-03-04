using System.Net.Http;

namespace DotNetLaunchDashboard.Builders
{
    public abstract class TelemetryParametersBuilderBase<T> : MissionParametersBuilderBase<T>
    {
        protected TelemetryParametersBuilderBase(HttpClient httpClient, string company) : base(httpClient, company)
        {

        }

        public MissionParametersBuilderBase<T> WithStart(int start)
        {
            AddParameter("start", start);
            return this;
        }

        public MissionParametersBuilderBase<T> WithStart(string start)
        {
            AddParameter("start", start);
            return this;
        }

        public MissionParametersBuilderBase<T> WithEnd(int end)
        {
            AddParameter("end", end);
            return this;
        }

        public MissionParametersBuilderBase<T> WithEnd(string end)
        {
            AddParameter("end", end);
            return this;
        }

        public MissionParametersBuilderBase<T> WithStartOffset(int startOffset)
        {
            AddParameter("start_offset", startOffset);
            return this;
        }

        public MissionParametersBuilderBase<T> WithEndOffset(int endOffset)
        {
            AddParameter("end_offset", endOffset);
            return this;
        }

        public MissionParametersBuilderBase<T> WithEvent(string @event)
        {
            AddParameter("event", @event);
            return this;
        }

        public MissionParametersBuilderBase<T> WithEventOffset(int eventOffset)
        {
            AddParameter("event_offset", eventOffset);
            return this;
        }

        public MissionParametersBuilderBase<T> WithFrameRate(int frameRate)
        {
            AddParameter("frame_rate", frameRate);
            return this;
        }

        public MissionParametersBuilderBase<T> WithInterval(int interval)
        {
            AddParameter("interval", interval);
            return this;
        }

        public MissionParametersBuilderBase<T> WithStage(int stage)
        {
            AddParameter("stage", stage);
            return this;
        }
    }
}
