/**
 * NumberedListItem automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace SdkFabric.Notion;

public class NumberedListItem
{
    [JsonPropertyName("rich_text")]
    public System.Collections.Generic.List<RichText>? RichText { get; set; }

    [JsonPropertyName("color")]
    public string? Color { get; set; }

    [JsonPropertyName("children")]
    public System.Collections.Generic.List<Block>? Children { get; set; }

}

