using System.Text.Json.Serialization;

namespace TPVModels.Models.UnitsMeasure.Tables;

public class CAT_UNIT_MEASURES
{
    
    [JsonPropertyName("idUnitMeasure")]
    public int idUnitMeasure { get; set; }
    
    [JsonPropertyName("unitName")]
    public string? unitName { get; set; }

    [JsonPropertyName("idStatus")]
    public int idStatus { get; set; }
    
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public DateTime? updatedAt { get; set; }
    
}