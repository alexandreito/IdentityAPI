namespace Identity.API.Configuration
{
    public static class EnvironmentConfig
    {
        public static IConfigurationManager AddEnviromentConfiguration(this IConfigurationManager configuration, IWebHostEnvironment env)
        {
            configuration
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();

            if (env.IsDevelopment())
            {
                configuration.AddUserSecrets<Program>();
            }

            return configuration;
        }
    }
}
