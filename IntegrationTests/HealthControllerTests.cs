using System.Net;
using System.Threading.Tasks;
using DotnetCore.Api.Sandbox;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Xunit;

namespace IntegrationTests
{
    public class HealthControllerTests
    {
        [Fact]
        public async Task GetHealth()
        {
            var webHostBuilder = new WebHostBuilder()
                .UseStartup<Startup>();

            var server = new TestServer(webHostBuilder);

            var client = server.CreateClient();

            var result = await client.GetAsync("/health");
            
            Assert.Equal(HttpStatusCode.OK, result.StatusCode);
        }
    }
}