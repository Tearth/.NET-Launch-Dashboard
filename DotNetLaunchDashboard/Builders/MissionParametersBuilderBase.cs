using System.Net.Http;

namespace DotNetLaunchDashboard.Builders
{
    /// <summary>
    /// Base class for all query builders, with support for mission parameters.
    /// </summary>
    /// <typeparam name="T">Type of the class, to which the API response will be deserialized.</typeparam>
    public abstract class MissionParametersBuilderBase<T> : BuilderBase<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissionParametersBuilderBase{T}"/> class.
        /// </summary>
        /// <param name="httpClient">HTTP client which will be used to communication with the API.</param>
        /// <param name="company">Company name for which requested data belongs.</param>
        protected MissionParametersBuilderBase(HttpClient httpClient, string company) : base(httpClient, company)
        {

        }

        /// <summary>
        /// Sets mission ID which will be used to identify data.
        /// </summary>
        /// <param name="missionId">Mission ID (like "crs-18").</param>
        /// <returns>Builder instance ready to execute.</returns>
        public BuilderBase<T> WithMissionId(int missionId)
        {
            AddParameter("mission_id", missionId);
            return this;
        }

        /// <summary>
        /// Sets flight number which will be used to identify data.
        /// </summary>
        /// <param name="flightNumber">Flight number from the launch provider's first flight (like "26").</param>
        /// <returns>Builder instance ready to execute.</returns>
        public BuilderBase<T> WithFlightNumber(int flightNumber)
        {
            AddParameter("flight_number", flightNumber);
            return this;
        }

        /// <summary>
        /// Sets launch library ID which will be used to identify data.
        /// </summary>
        /// <param name="launchLibraryId">Internal API ID.</param>
        /// <returns>Builder instance ready to execute.</returns>
        public BuilderBase<T> WithLaunchLibraryId(int launchLibraryId)
        {
            AddParameter("launch_library_id", launchLibraryId);
            return this;
        }
    }
}
