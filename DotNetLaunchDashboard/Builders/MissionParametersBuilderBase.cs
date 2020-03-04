using System.Net.Http;

namespace DotNetLaunchDashboard.Builders
{
    public abstract class MissionParametersBuilderBase<T> : BuilderBase<T>
    {
        protected MissionParametersBuilderBase(HttpClient httpClient, string company) : base(httpClient, company)
        {

        }

        public BuilderBase<T> WithMissionId(int missionId)
        {
            AddParameter("mission_id", missionId);
            return this;
        }

        public BuilderBase<T> WithFlightNumber(int flightNumber)
        {
            AddParameter("flight_number", flightNumber);
            return this;
        }

        public BuilderBase<T> WithLaunchLibraryId(int launchLibraryId)
        {
            AddParameter("launch_library_id", launchLibraryId);
            return this;
        }
    }
}
