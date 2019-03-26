using System.Threading.Tasks;

namespace DotnetCore.Api.Sandbox.Services
{
    public class SampleService : ISampleService
    {
        public async Task<int> GetNumberAsync()
        {
            await Task.Delay(3);

            return 40;
        }
    }
}