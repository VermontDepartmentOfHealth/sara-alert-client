using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

namespace SaraAlertApi
{
    class Startup
    {

        public AppSettings GetConfigSettings()
        {
            //strongly typed config attributes
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                 .AddJsonFile("appsecrets.json", optional: false, reloadOnChange: true)
                 .AddJsonFile("apptoken.json", optional: false, reloadOnChange: true)
                 .Build();

            var appSettings = new AppSettings();
            configuration.Bind(appSettings);

            return appSettings;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDatabaseConfig, AppSettings>();
        }

    }
}
