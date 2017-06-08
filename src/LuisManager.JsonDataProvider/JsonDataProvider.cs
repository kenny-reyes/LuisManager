using LuisManager.Common.Contracts;
using LuisManager.Common.Contracts.Helpers;
using LuisManager.Domain;

namespace LuisManager.JsonDataProvider
{
    public class JsonDataProvider : IDataProvider
    {
        private readonly IConfigurationService _configuration;
        private readonly IFileHelper _fileHelper;
        private readonly IJsonHelper _jsonHelper;

        public JsonDataProvider(IConfigurationService configuration, IFileHelper fileHelper, IJsonHelper jsonHelper)
        {
            _configuration = configuration;
            _fileHelper = fileHelper;
            _jsonHelper = jsonHelper;
        }

        public LuisScheme GetData()
        {
            var jsonFilePath = _configuration.Configuration.JsonFilePath;

            return _jsonHelper.Deserialize<LuisScheme>(_fileHelper.ReadTextFile(jsonFilePath));
        }

        public void SetData(LuisScheme luisSchemes)
        {
            var jsonFilePath = _configuration.Configuration.JsonFilePath;

            _fileHelper.WriteTextFile(jsonFilePath, _jsonHelper.Serialize(luisSchemes));
        }
    }
}
