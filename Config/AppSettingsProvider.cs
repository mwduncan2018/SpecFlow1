using System.IO;
using Microsoft.Extensions.Configuration;

namespace SpecFlowBdd.Config
{
    public class AppSettingsProvider
    {
        private readonly IConfiguration configuration;

        public AppSettings GetSetting()
        {
            return configuration.Get<AppSettings>();
        }

        public AppSettingsProvider()
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(
                    Directory.GetCurrentDirectory()).ToString() + "\\SpecFlowBdd\\Config")
                .AddJsonFile("appsettings.json", false, true)
                .Build();
        }
    }
}
