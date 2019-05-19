// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.V2.Models
{
    using Newtonsoft.Json;

    using System.Reflection;

    /// <summary>
    /// Defines values for ImportConflictHandlerMode.
    /// </summary>
    public sealed class ImportConflictHandlerModeConverter : JsonConverter
    {

        /// <summary>
        /// Returns if objectType can be converted to ImportConflictHandlerMode
        /// by the converter.
        /// </summary>
        public override bool CanConvert(System.Type objectType)
        {
            return typeof(ImportConflictHandlerMode).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }

        /// <summary>
        /// Overrides ReadJson and converts token to ImportConflictHandlerMode.
        /// </summary>
        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == Newtonsoft.Json.JsonToken.Null)
            {
                return null;
            }
            return (ImportConflictHandlerMode)serializer.Deserialize<string>(reader);
        }

        /// <summary>
        /// Overriding WriteJson for ImportConflictHandlerMode for
        /// serialization.
        /// </summary>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

    }
}
