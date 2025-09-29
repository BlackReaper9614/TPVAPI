using System.Text.Json.Serialization;

namespace TPVModels.Models.Subfamilies.Tables;

public class CAT_SUBFAMILIES
{
    
    [JsonPropertyName("idSubfamily")]
    public int idSubfamily { get; set; }
    
    [JsonPropertyName("subfamilyName")]
    public string? subfamilyName { get; set; }
    
    [JsonPropertyName("idFamily")]
    public int idFamily { get; set; }

    [JsonPropertyName("idStatus")]
    public int idStatus { get; set; }
 
    [JsonPropertyName("cretedAt")]
    public DateTime? cretedAt { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public DateTime? updatedAt { get; set; }
    
}