using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ErrorHandling.Controllers
{
    public class Json
    {
        public static string Serialize(object data)
        {
            return JsonConvert.SerializeObject(data, JsonConvertSettings());
        }

        public static T Deserialize<T>(string serializedData)
        {
            return JsonConvert.DeserializeObject<T>(serializedData, JsonConvertSettings());
        }

        private static JsonSerializerSettings JsonConvertSettings()
        {
            return new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
        }
    }
}
