/**
 * ExternalIcon automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;

namespace SdkFabric.Notion;

public class ExternalIcon : Icon
{
    [JsonPropertyName("external")]
    public ExternalObject? External { get; set; }

}

