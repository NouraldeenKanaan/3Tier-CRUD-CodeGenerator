using Microsoft.Extensions.Configuration;
public static class clsAppConfigurations
{
    private static readonly IConfigurationRoot configuration;

    static clsAppConfigurations()
    {
        configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
    }

    public static string ConnectionString =>
        configuration.GetConnectionString("Default")!;

}