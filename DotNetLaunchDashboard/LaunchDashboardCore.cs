using System;
using System.Net.Http;
using DotNetLaunchDashboard.Builders.EndpointBuilders;

namespace DotNetLaunchDashboard
{
    public class LaunchDashboardCore : IDisposable
    {
        private readonly HttpClient _httpClient;

        public LaunchDashboardCore()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Configuration.BaseApiAddress);
        }

        public InfoBuilder Info()
        {
            return new InfoBuilder(_httpClient);
        }

        public AnalysedBuilder Analysed(string company)
        {
            return new AnalysedBuilder(_httpClient, company);
        }

        public EventsBuilder Events(string company)
        {
            return new EventsBuilder(_httpClient, company);
        }

        public LaunchesBuilder Launches(string company)
        {
            return new LaunchesBuilder(_httpClient, company);
        }

        public RawBuilder Raw(string company)
        {
            return new RawBuilder(_httpClient, company);
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}
