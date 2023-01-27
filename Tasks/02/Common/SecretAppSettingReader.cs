using Microsoft.Extensions.Configuration;

public class SecretAppsettingReader
{
    public static T? ReadSection<T, U>(string sectionName) where U : class
    {
        var builder = new ConfigurationBuilder().AddUserSecrets<U>();
        var configurationRoot = builder.Build();
        return configurationRoot.GetSection(sectionName).Get<T>();
    }
}
