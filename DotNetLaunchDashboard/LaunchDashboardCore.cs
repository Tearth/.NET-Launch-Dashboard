using DotNetLaunchDashboard.Builders.EndpointBuilders;

namespace DotNetLaunchDashboard
{
    public class LaunchDashboardCore
    {
        public InfoBuilder Info()
        {
            return new InfoBuilder();
        }

        public AnalysedBuilder Analysed(string company)
        {
            return new AnalysedBuilder(company);
        }

        public EventsBuilder Events(string company)
        {
            return new EventsBuilder(company);
        }

        public LaunchesBuilder Launches(string company)
        {
            return new LaunchesBuilder(company);
        }

        public RawBuilder Raw(string company)
        {
            return new RawBuilder(company);
        }
    }
}
