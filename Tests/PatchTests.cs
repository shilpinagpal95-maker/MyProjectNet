using NUnit.Framework;
using Framework;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Tests
{
    public class PatchTests
    {
        private ApiClient _client;
        private string _baseUrl;

        [SetUp]
        public void Setup()
        {
            _client = new ApiClient(new HttpClient());
            _baseUrl = ConfigReader.Get("ApiBaseUrl");
        }

        [Test]
        [TestCaseSource("GetPatchData")]
        public async Task PatchEndpointTest(dynamic testData)
        {
            var response = await _client.PatchAsync($"{_baseUrl}/resource/{testData.id}", testData);
            Assert.AreEqual((int)testData.expectedStatus, (int)response.StatusCode);
        }

        public static IEnumerable<dynamic> GetPatchData()
        {
            var json = File.ReadAllText("Data/PatchTestData.json");
            return JArray.Parse(json);
        }
    }
}
