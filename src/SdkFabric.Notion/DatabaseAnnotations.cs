/**
 * DatabaseAnnotations automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace SdkFabric.Notion;
public class DatabaseAnnotations
{
    [JsonPropertyName("bold")]
    public bool? Bold { get; set; }
    [JsonPropertyName("italic")]
    public bool? Italic { get; set; }
    [JsonPropertyName("strikethrough")]
    public bool? Strikethrough { get; set; }
    [JsonPropertyName("underline")]
    public bool? Underline { get; set; }
    [JsonPropertyName("code")]
    public bool? Code { get; set; }
    [JsonPropertyName("color")]
    public string? Color { get; set; }
}