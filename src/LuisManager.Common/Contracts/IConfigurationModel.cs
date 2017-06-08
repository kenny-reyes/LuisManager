

namespace LuisManager.Common.Contracts
{
    public interface IConfigurationModel
    {
        string JsonFilePath { get; }
        string DataSourceUrl { get; }
    }
}