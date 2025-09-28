using System.Text.Json.Serialization;

namespace TPVModels.Models.Families.Tables;

public class CAT_FAMILIES
{

    [JsonPropertyName("idFamily")]
    public int idFamily { get; set; }
    
    [JsonPropertyName("familyName")]
    public string? familyName { get; set; }

    [JsonPropertyName("idStatus")]
    public int idStatus { get; set; }
    
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public DateTime? updatedAt { get; set; }

}