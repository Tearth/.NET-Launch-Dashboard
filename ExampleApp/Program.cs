using System;
using System.Threading.Tasks;
using DotNetLaunchDashboard;
using DotNetLaunchDashboard.Live;

namespace ExampleApp
{
    class Program
    {
        static async Task Main()
        {
            var liveTelemetry = new LiveTelemetry();
            liveTelemetry.OnConnected += (sender, args) => Console.WriteLine("Connected to the live telemetry stream");
            liveTelemetry.OnClosed += (sender, args) => Console.WriteLine($"Disconnected from the live telemetry stream (reason: {args})");
            liveTelemetry.OnError += (sender, args) => Console.WriteLine($"Error: {args.Text}");
            liveTelemetry.OnRawTelemetry += (sender, args) =>
                Console.WriteLine($"Raw: time: {args.Time}, " +
                                  $"alt: {args.Altitude}, " +
                                  $"vel: {args.Velocity}");
            liveTelemetry.OnAnalysedTelemetry += (sender, args) =>
                Console.WriteLine($"Analysed: time: {args.Time}, " +
                                  $"alt: {args.Altitude}, " +
                                  $"vel: {args.Velocity}, " +
                                  $"velX: {args.VelocityX}, " +
                                  $"velY: {args.VelocityY}, " +
                                  $"dDist: {args.DownrangeDistance}, " +
                                  $"angle: {args.Angle}, " +
                                  $"q: {args.Q}");
            await liveTelemetry.Start();
            
            var launchDashboardCore = new LaunchDashboardCore();
            var result1 = await launchDashboardCore.Info().ExecuteAsync();
            var result2 = await launchDashboardCore.Analysed("spacex").WithFlightNumber(80).ExecuteAsync();
            var result3 = await launchDashboardCore.Events("spacex").WithFlightNumber(80).ExecuteAsync();
            var result4 = await launchDashboardCore.Launches("spacex").WithFlightNumber(80).ExecuteAsync();
            var result5 = await launchDashboardCore.Raw("spacex")
                .WithStart(10)
                .WithEnd(20)
                .WithInterval(1)
                .WithFlightNumber(80)
                .ExecuteAsync();

            Console.Read();
        }
    }
}
