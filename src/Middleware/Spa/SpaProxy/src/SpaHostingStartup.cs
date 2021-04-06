using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

[assembly: HostingStartup(typeof(Microsoft.AspNetCore.SpaProxy.SpaHostingStartup))]

namespace Microsoft.AspNetCore.SpaProxy
{
    internal class SpaHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                if (File.Exists(Path.Combine(AppContext.BaseDirectory, "spa.proxy.json")))
                {
                    services.AddHostedService<SpaProxyLaunchManager>();
                }
            });
        }
    }
}
