using System.Reflection;

namespace WebApi.Providers;

public static class GitVersionInformationProvider
{
    private static readonly Assembly? Assembly = Assembly.GetEntryAssembly();

    private static readonly Type? GitVersionInformationType = Assembly?.GetType("GitVersionInformation");

    public static string Copyright => Assembly?.GetCustomAttribute<AssemblyCopyrightAttribute>()?.Copyright ?? string.Empty;

    public static string FullSemVer => GetFieldValue("FullSemVer") ?? string.Empty;

    public static string ShortSha => GetFieldValue("ShortSha") ?? string.Empty;

    public static string Sha => GetFieldValue("Sha") ?? string.Empty;

    public static string InformationalVersion => GetFieldValue("InformationalVersion") ?? string.Empty;

    private static string? GetFieldValue(string name) => GitVersionInformationType?.GetField(name)?.GetValue(null)?.ToString();
}
