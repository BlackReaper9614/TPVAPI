using System.Text.Json.Serialization;

namespace TPVModels.Models.Items.Tables;

public class CAT_ITEMS
{
    [JsonPropertyName("idUser")]
    public int idUser { get; set; }
    
    [JsonPropertyName("idItem")]
    public int idItem { get; set; }
    
    [JsonPropertyName("itemInternalCode")]
    public string? itemInternalCode { get; set; }

    [JsonPropertyName("itemCodebar")]
    public string? itemCodebar { get; set; }
    
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
    
    [JsonPropertyName("stock")]
    public decimal stock { get; set; }
    
    [JsonPropertyName("idUnitMeasure")]
    public int idUnitMeasure { get; set; }
    
    [JsonPropertyName("idSubfamily")]
    public int idSubfamily { get; set; }
    
    [JsonPropertyName("idStatus")]
    public int idStatus { get; set; }
    
    [JsonPropertyName("createdBy")]
    public DateTime? createdBy { get; set; }
    
    [JsonPropertyName("createdAt")]
    public DateTime? createdAt { get; set; }
    
    [JsonPropertyName("updatedBy")]
    public int updatedBy { get; set; }
    
    [JsonPropertyName("updatedAt")]
    public DateTime updatedAt { get; set; }
    
    [JsonPropertyName("totalRows")]
    public int totalRows { get; set; }
    
}