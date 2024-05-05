/**
 * Page automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
using System.Collections.Generic;
namespace SdkFabric.Notion;
public class Page
{
    [JsonPropertyName("object")]
    public string? Object { get; set; }
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("created_time")]
    public DateTime? CreatedTime { get; set; }
    [JsonPropertyName("last_edited_time")]
    public DateTime? LastEditedTime { get; set; }
    [JsonPropertyName("created_by")]
    public User? CreatedBy { get; set; }
    [JsonPropertyName("last_edited_by")]
    public User? LastEditedBy { get; set; }
    [JsonPropertyName("cover")]
    public string? Cover { get; set; }
    [JsonPropertyName("icon")]
    public string? Icon { get; set; }
    [JsonPropertyName("parent")]
    public string? Parent { get; set; }
    [JsonPropertyName("in_trash")]
    public bool? InTrash { get; set; }
    [JsonPropertyName("properties")]
    public Dictionary<string, object>? Properties { get; set; }
}
