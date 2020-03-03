namespace DotNetLaunchDashboard.Builders
{
    public abstract class MissionParametersBuilderBase<T> : BuilderBase<T>
    {
        protected MissionParametersBuilderBase(string company) : base(company)
        {

        }

        public MissionParametersBuilderBase<T> WithMissionId(int missionId)
        {
            AddParameter("mission_id", missionId);
            return this;
        }

        public MissionParametersBuilderBase<T> WithFlightNumber(int flightNumber)
        {
            AddParameter("flight_number", flightNumber);
            return this;
        }

        public MissionParametersBuilderBase<T> WithLaunchLibraryId(int launchLibraryId)
        {
            AddParameter("launch_library_id", launchLibraryId);
            return this;
        }
    }
}
