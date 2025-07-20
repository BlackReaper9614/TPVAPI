using System.Text.Json.Serialization;

namespace TPVModels.Models.Items.SPs;

public class SP_GET_ITEMS_BY_USER
{

    [JsonPropertyName("idItem")]
    public int idItem { get; set; }
    
    [JsonPropertyName("itemInternalCode")]
    public string? itemInternalCode { get; set; }
    
    [JsonPropertyName("itemCodeBar")]
    public string? itemCodeBar { get; set; }
    
    [JsonPropertyName("itemName")]
    public string? itemName { get; set; }
    
    [JsonPropertyName("purchaseCost")]
    public decimal purchaseCost { get; set; }
    
    [JsonPropertyName("sellCost")]
    public decimal sellCost { get; set; }
    
    [JsonPropertyName("itemBrand")]
    public string? itemBrand { get; set; }
    
    [JsonPropertyName("itemModel")]
    public string? itemModel { get; set; }
    
    [JsonPropertyName("intstock")]
    public decimal intstock { get; set; }
    
    [JsonPropertyName("idUnitMeasure")]
    public int idUnitMeasure { get; set; }
    
    [JsonPropertyName("idSubfamily")]
    public int idSubfamily { get; set; }
    
    [JsonPropertyName("idStatus")]
    public int idStatus { get; set; }
    
    [JsonPropertyName("createdBy")]
    public int createdBy { get; set; }
    
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; }
    
    [JsonPropertyName("updatedBy")]
    public int updatedBy { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public DateTime? updatedAt { get; set; }

}