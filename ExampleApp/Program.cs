using System;
using System.Threading.Tasks;
using DotNetLaunchDashboard;

namespace ExampleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var launchDashboardCore = new LaunchDashboardCore();
            var result1 = await launchDashboardCore.Info().ExecuteAsync();
            var result2 = await launchDashboardCore.Analysed("spacex").WithFlightNumber(80).ExecuteAsync();
            var result3 = await launchDashboardCore.Events("spacex").WithFlightNumber(80).ExecuteAsync();
            var result4 = await launchDashboardCore.Launches("spacex").WithFlightNumber(80).ExecuteAsync();
            var result5 = await launchDashboardCore.Raw("spacex").WithFlightNumber(80).ExecuteAsync();

            Console.Read();
        }
    }
}
