using System;

namespace DotNetLaunchDashboard.Exceptions
{
    /// <summary>
    /// The exception that is thrown when API returns response with bad code.
    /// </summary>
    public class ApiErrorException : Exception
    {
        /// <inheritdoc />
        public ApiErrorException()
        {

        }

        /// <inheritdoc />
        public ApiErrorException(string message) : base(message)
        {

        }

        /// <inheritdoc />
        public ApiErrorException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
