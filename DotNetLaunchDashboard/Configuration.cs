namespace DotNetLaunchDashboard
{
    /// <summary>
    /// Contains API configuration.
    /// </summary>
    public static class Configuration
    {
        /// <summary>
        /// Base API address used in all query builders.
        /// </summary>
        public static string BaseApiAddress = "https://api.launchdashboard.space/";

        /// <summary>
        /// Base API address (with the specified version) used in all query builders.
        /// </summary>
        public static string BaseApiAddressWithVersion = BaseApiAddress + "v1/";
    }
}
