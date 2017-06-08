using LuisManager.Common.Contracts.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace LuisManager.WPF.Helpers
{
    public class JsonHelper : IJsonHelper
    {
        public JsonHelper()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore,
            };
        }

        public T Deserialize<T>(string serializedObject)
        {
            return string.IsNullOrWhiteSpace(serializedObject)
            ? default(T)
            : JsonConvert.DeserializeObject<T>(serializedObject, new StringEnumConverter());
        }

        public string Serialize<T>(T objectToSerialize)
        {
            return JsonConvert.SerializeObject(objectToSerialize);
        }
    }
}
