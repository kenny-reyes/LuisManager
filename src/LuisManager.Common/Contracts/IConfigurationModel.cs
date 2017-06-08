namespace LuisManager.Common.Contracts
{
    public interface IConfigurationModel
    {
        string JsonFilePath { set; get; }
        string DataSourceUrl { set; get; }
    }
}