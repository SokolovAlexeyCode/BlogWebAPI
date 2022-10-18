namespace SokolDev.Settings.SettingModels;

public class DataStorageOptions
{
    public const string DataStorage = "DataStorage";

    public ConnectionStringsOptions ConnectionStringsOptions { get; set; } = new();

    public string StorageType { get; set; } = string.Empty;
}