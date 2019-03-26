using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotnetCore.Api.Sandbox.Services
{
    public class SampleFilter : ServiceFilterAttribute, IAsyncActionFilter
    {
        private readonly ISampleService _repository;
        
        public SampleFilter(ISampleService repository) : base(typeof(SampleFilter))
        {
            _repository = repository;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {   
            var result = await _repository.GetNumberAsync();

            Console.WriteLine(result);
        }
    }
}