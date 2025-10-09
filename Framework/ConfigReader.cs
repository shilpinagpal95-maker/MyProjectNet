using Microsoft.Extensions.Configuration;

namespace Framework
{
    public static class ConfigReader
    {
        private static IConfigurationRoot config;
        static ConfigReader()
        {
            config = new ConfigurationBuilder()
                .AddJsonFile("Config/appsettings.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        }

        public static string Get(string key) => config[key];
    }
}
