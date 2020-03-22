# .NET Launch Dashboard
[![GitHub release](https://img.shields.io/github/release/Tearth/.NET-Launch-Dashboard.svg)](https://github.com/Tearth/.NET-Launch-Dashboard/releases)
[![Build](https://travis-ci.org/Tearth/.NET-Launch-Dashboard.svg?branch=develop)](https://travis-ci.org/Tearth/.NET-Launch-Dashboard)
[![NuGet downloads](https://img.shields.io/nuget/dt/.NET-Launch-Dashboard.svg)](https://www.nuget.org/packages/.NET-Launch-Dashboard/)
[![GitHub issues](https://img.shields.io/github/issues/Tearth/.NET-Launch-Dashboard.svg)](https://github.com/Tearth/.NET-Launch-Dashboard/issues)
[![GitHub stars](https://img.shields.io/github/stars/Tearth/.NET-Launch-Dashboard.svg)](https://github.com/Tearth/.NET-Launch-Dashboard/stargazers)
[![GitHub license](https://img.shields.io/github/license/Tearth/.NET-Launch-Dashboard.svg)](https://github.com/Tearth/.NET-Launch-Dashboard/blob/master/LICENSE)
[![GitHub license](https://img.shields.io/badge/Doxygen-gh--pages-blue)](https://tearth.github.io/.NET-Launch-Dashboard/)

Wrapper for [.NET Launch Dashboard](https://github.com/shahar603/Launch-Dashboard-API) project, providing information about the telemetry of launching rockets. To learn more, you can use [Doxygen](https://tearth.github.io/.NET-Launch-Dashboard/) or directly documentation of the API (method names are very familiar with endpoints):

https://github.com/shahar603/Launch-Dashboard-API/wiki

# Minimal requirements
Library is build on [.NET Standard 2.0](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) which contains support for:
 * .NET Framework 4.6.1 or higher
 * .NET Core 2.0 or higher
 * Mono 5.4 or higher
 * Xamarin.iOS 10.14 or higher
 * Xamarin.Mac 3.8 or higher
 * Xamarin.Android 8.0 or higher
 * Universal Windows Platform 10.0.16299 or higher

**External dependencies:**
 * [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json)
 * [SocketIOClient](https://github.com/doghappy/socket.io-client-csharp)

# Installation
 * download from NuGet: https://www.nuget.org/packages/DotNetLaunchDashboard/

or

 * search "DotNetLaunchDashboard" in Package Manager

or

 * run `Install-Package DotNetLaunchDashboard` in the Package Manager Console

# Example usage
```csharp
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
            await liveTelemetry.StartAsync();
            
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
```