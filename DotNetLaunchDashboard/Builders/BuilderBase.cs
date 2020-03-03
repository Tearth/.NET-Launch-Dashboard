using System.Net.Http;
using System.Threading.Tasks;

namespace DotNetLaunchDashboard.Builders
{
    public abstract class BuilderBase<T>
    {
        protected abstract string Endpoint { get; set; }
        private HttpClient _httpClient;

        protected BuilderBase()
        {
            _httpClient = new HttpClient();
        }

        public T Execute()
        {
            return ExecuteAsync().GetAwaiter().GetResult();
        }

        public async Task<T> ExecuteAsync()
        {
            return await ExecuteBuilder().ConfigureAwait(false);
        }

        protected abstract Task<T> ExecuteBuilder();
    }
}
