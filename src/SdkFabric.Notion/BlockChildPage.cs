/**
 * BlockChildPage automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace SdkFabric.Notion;

public class BlockChildPage : Block
{
    [JsonPropertyName("child_page")]
    public ChildPage? ChildPage { get; set; }

}

