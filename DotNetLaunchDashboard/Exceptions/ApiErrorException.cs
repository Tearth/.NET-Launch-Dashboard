using System;

namespace DotNetLaunchDashboard.Exceptions
{
    public class ApiErrorException : Exception
    {
        public ApiErrorException()
        {

        }

        public ApiErrorException(string message) : base(message)
        {

        }

        public ApiErrorException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
