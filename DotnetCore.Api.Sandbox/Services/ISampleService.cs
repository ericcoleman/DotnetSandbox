using System.Threading.Tasks;

namespace DotnetCore.Api.Sandbox.Services
{
    public interface ISampleService
    {
        Task<int> GetNumberAsync();
    }
}