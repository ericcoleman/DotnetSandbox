using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotnetCore.Api.Sandbox
{
    public class SampleFilter : ServiceFilterAttribute, IAsyncActionFilter
    {
        public SampleFilter() : base(typeof(SampleFilter)) { }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await Task.Delay(9);

            Console.WriteLine(9);
        }
    }
}