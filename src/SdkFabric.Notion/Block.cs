/**
 * Block automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace SdkFabric.Notion;
public class Block
{
    [JsonPropertyName("object")]
    public string? Object { get; set; }
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("parent")]
    public Page? Parent { get; set; }
    [JsonPropertyName("created_time")]
    public DateTime? CreatedTime { get; set; }
    [JsonPropertyName("last_edited_time")]
    public DateTime? LastEditedTime { get; set; }
    [JsonPropertyName("created_by")]
    public User? CreatedBy { get; set; }
    [JsonPropertyName("last_edited_by")]
    public User? LastEditedBy { get; set; }
    [JsonPropertyName("has_children")]
    public bool? HasChildren { get; set; }
    [JsonPropertyName("in_trash")]
    public bool? InTrash { get; set; }
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}
