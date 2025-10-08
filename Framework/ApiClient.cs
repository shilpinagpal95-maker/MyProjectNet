using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Framework
{
    public class ApiClient
    {
        private readonly HttpClient _client;
        public ApiClient(HttpClient client) => _client = client;

        public async Task<HttpResponseMessage> PatchAsync<T>(string url, T data)
        {
            var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage(new HttpMethod("PATCH"), url) { Content = content };
            return await _client.SendAsync(request);
        }
    }
}