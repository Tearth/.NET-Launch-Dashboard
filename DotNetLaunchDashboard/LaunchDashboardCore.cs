using DotNetLaunchDashboard.Builders.EndpointBuilders;

namespace DotNetLaunchDashboard
{
    public class LaunchDashboardCore
    {
        public AnalysedBuilder Analysed(string company)
        {
            return new AnalysedBuilder(company);
        }
    }
}
