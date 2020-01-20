using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

[assembly: FunctionsStartup(typeof(Bl0g.Content.AzureFunctions.Startup))]
namespace Bl0g.Content.AzureFunctions
{ 
    public class HostingOptions
    {
        public string ASPNETCORE_ENVIRONMENT { get; set; }
        public string AZURE_FUNCTIONS_ENVIRONMENT { get; set; }
    }
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddOptions<HostingOptions>()
                .Configure<IConfiguration>((settings, configuration) =>
                {
                    configuration.Bind(settings);
                });
        }
    }
}
