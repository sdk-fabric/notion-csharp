/**
 * RichText automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace SdkFabric.Notion;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(RichTextEquation), typeDiscriminator: "equation")]
[JsonDerivedType(typeof(RichTextText), typeDiscriminator: "text")]
public abstract class RichText
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("annotations")]
    public RichTextAnnotation? Annotations { get; set; }

    [JsonPropertyName("plain_text")]
    public string? PlainText { get; set; }

    [JsonPropertyName("href")]
    public string? Href { get; set; }

}

