using System;
using System.Net.Http;
using DotNetLaunchDashboard.Builders.EndpointBuilders;

namespace DotNetLaunchDashboard
{
    /// <summary>
    /// Core of the wrapper, use this class to communicate with the API.
    /// </summary>
    public class LaunchDashboardCore : IDisposable
    {
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="LaunchDashboardCore"/> class.
        /// </summary>
        public LaunchDashboardCore()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Configuration.BaseApiAddress);
        }

        /// <summary>
        /// Creates and returns builder for "info" endpoint.
        /// </summary>
        /// <returns>Builder for "info" endpoint.</returns>
        public InfoBuilder Info()
        {
            return new InfoBuilder(_httpClient);
        }

        /// <summary>
        /// Creates and returns builder for "analysed" endpoint.
        /// </summary>
        /// <param name="company">Name of the company which launched the rocket.</param>
        /// <returns>Builder for "analysed" endpoint.</returns>
        public AnalysedBuilder Analysed(string company)
        {
            return new AnalysedBuilder(_httpClient, company);
        }

        /// <summary>
        /// Creates and returns builder for "events" endpoint.
        /// </summary>
        /// <param name="company">Name of the company which launched the rocket.</param>
        /// <returns>Builder for "events" endpoint.</returns>
        public EventsBuilder Events(string company)
        {
            return new EventsBuilder(_httpClient, company);
        }

        /// <summary>
        /// Creates and returns builder for "launches" endpoint.
        /// </summary>
        /// <param name="company">Name of the company which launched the rocket.</param>
        /// <returns>Builder for "launches" endpoint.</returns>
        public LaunchesBuilder Launches(string company)
        {
            return new LaunchesBuilder(_httpClient, company);
        }

        /// <summary>
        /// Creates and returns builder for "raw" endpoint.
        /// </summary>
        /// <param name="company">Name of the company which launched the rocket.</param>
        /// <returns>Builder for "raw" endpoint.</returns>
        public RawBuilder Raw(string company)
        {
            return new RawBuilder(_httpClient, company);
        }

        /// <inheritdoc />
        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}
