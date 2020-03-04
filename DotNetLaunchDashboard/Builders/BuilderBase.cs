using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DotNetLaunchDashboard.Exceptions;
using DotNetLaunchDashboard.Models.Responses;
using Newtonsoft.Json;

namespace DotNetLaunchDashboard.Builders
{
    /// <summary>
    /// Base class for all query builders.
    /// </summary>
    /// <typeparam name="T">Type of the class, to which the API response will be deserialized.</typeparam>
    public abstract class BuilderBase<T>
    {
        /// <summary>
        /// Name of the endpoint which will be called
        /// </summary>
        protected abstract string Endpoint { get; set; }

        private readonly HttpClient _httpClient;
        private readonly string _company;
        private readonly Dictionary<string, string> _parameters;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuilderBase{T}"/> class.
        /// </summary>
        /// <param name="httpClient">HTTP client which will be used to communication with the API.</param>
        /// <param name="company">Company name for which requested data belongs.</param>
        protected BuilderBase(HttpClient httpClient, string company)
        {
            _httpClient = httpClient;
            _company = company;

            _parameters = new Dictionary<string, string>();
        }

        /// <summary>
        /// Executes prepared query and returns deserialized data received from the API.
        /// </summary>
        /// <exception cref="ApiErrorException">The exception that is thrown when API returns response with bad code.</exception>
        /// <exception cref="HttpRequestException">The exception that is thrown when HTTP client can't connect to the API.</exception>
        /// <returns>Deserialized data received from the API.</returns>
        public T Execute()
        {
            return ExecuteAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Executes asynchronously prepared query and returns deserialized data received from the API.
        /// </summary>
        /// <exception cref="ApiErrorException">The exception that is thrown when API returns response with bad code.</exception>
        /// <exception cref="HttpRequestException">The exception that is thrown when HTTP client can't connect to the API.</exception>
        /// <returns>Task with deserialized data received from the API.</returns>
        public async Task<T> ExecuteAsync()
        {
            return await ExecuteBuilderAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Adds parameter (string) to the query.
        /// </summary>
        /// <param name="key">Name of the parameter.</param>
        /// <param name="value">Value of the parameter.</param>
        protected void AddParameter(string key, string value)
        {
            _parameters.Add(key, value);
        }

        /// <summary>
        /// Adds parameter (int) to the query.
        /// </summary>
        /// <param name="key">Name of the parameter.</param>
        /// <param name="value">Value of the parameter.</param>
        protected void AddParameter(string key, int value)
        {
            _parameters.Add(key, value.ToString());
        }

        private async Task<T> ExecuteBuilderAsync()
        {
            var serializedParameters = string.Join("&", _parameters.Select(p => $"{p.Key}={p.Value}"));
            var path = $"{Endpoint}/{_company}?{serializedParameters}".TrimStart('/');

            var response = await _httpClient.GetAsync(path).ConfigureAwait(false);
            var responseContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            
            if (!response.IsSuccessStatusCode)
            {
                var errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(responseContent);
                throw new ApiErrorException($"The API returned a {(int)response.StatusCode} response with this message: {errorResponse.Error}");
            }

            return JsonConvert.DeserializeObject<T>(responseContent);
        }
    }
}
