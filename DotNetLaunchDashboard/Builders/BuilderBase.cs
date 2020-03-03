using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DotNetLaunchDashboard.Builders
{
    public abstract class BuilderBase<T>
    {
        protected abstract string Endpoint { get; set; }

        private readonly HttpClient _httpClient;
        private readonly string _company;
        private readonly Dictionary<string, string> _parameters;

        protected BuilderBase(string company)
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Configuration.BaseApiAddress);

            _company = company;
            _parameters = new Dictionary<string, string>();
        }

        public T Execute()
        {
            return ExecuteAsync().GetAwaiter().GetResult();
        }

        public async Task<T> ExecuteAsync()
        {
            return await ExecuteBuilderAsync().ConfigureAwait(false);
        }

        protected void AddParameter(string key, string value)
        {
            _parameters.Add(key, value);
        }

        protected void AddParameter(string key, int value)
        {
            _parameters.Add(key, value.ToString());
        }

        private async Task<T> ExecuteBuilderAsync()
        {
            var serializedParameters = string.Join("&", _parameters.Select(p => $"{p.Key}={p.Value}"));
            var pathWithParameters = $"{Endpoint}?{serializedParameters}";
            var fullPath = Path.Combine(_company, pathWithParameters);

            var response = await _httpClient.GetStringAsync(fullPath);
            var deserializedResponse = JsonConvert.DeserializeObject<T>(response);

            return deserializedResponse;
        }
    }
}
