namespace SokolDev.Settings.SettingModels;

public class ConnectionStringsOptions
{
    public const string ConnectionStrings = "ConnectionStrings";

    public string SQLite { get; set; } = string.Empty;
    public string MsSql { get; set; } = string.Empty;
    public string PostgreSQL { get; set; } = string.Empty;
}