using Microsoft.Extensions.Configuration;

public class SecretAppsettingReader
{
    public static T? ReadSection<T>(string sectionName)
    {
        var builder = new ConfigurationBuilder().AddUserSecrets<Program>();
        var configurationRoot = builder.Build();
        return configurationRoot.GetSection(sectionName).Get<T>();
    }
}
