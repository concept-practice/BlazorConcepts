using System.Reflection;
using System.Threading.Tasks;
using BlazorConcepts.Pages.Store;
using MediatR;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorConcepts
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddBaseAddressHttpClient();

            builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
            builder.Services.AddSingleton<MediatorState>();

            await builder.Build().RunAsync();
        }
    }
}
