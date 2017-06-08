using LuisManager.Common.Contracts;
using LuisManager.Common.Contracts.Helpers;

namespace LuisManager.ConfigurationService
{
    public class ConfigurationService : IConfigurationService
    {
        const string ConfigurationFilePath = "Config.json";

        public ConfigurationService(IFileHelper fileHelper, IJsonHelper jsonHelper)
        {
            Configuration = jsonHelper.Deserialize<ConfigurationModel>(fileHelper.ReadTextFile(fileHelper.ActualPath + ConfigurationFilePath));
        }

        public IConfigurationModel Configuration
        {
            get;
        } 
    }
}
