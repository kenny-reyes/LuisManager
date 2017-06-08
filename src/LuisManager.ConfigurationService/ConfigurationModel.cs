using LuisManager.Common.Contracts;

namespace LuisManager.ConfigurationService
{
    public class ConfigurationModel : IConfigurationModel
    {
        public string JsonFilePath { get; set; }
        public string DataSourceUrl { get; set; }
    }
}
