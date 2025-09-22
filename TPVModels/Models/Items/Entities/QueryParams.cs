using System.Text.Json.Serialization;

namespace TPVModels.Models.Items.Entities;

public class QueryParams
{

    [JsonPropertyName("idUser")]
    public int idUser { get; set; }
    
    [JsonPropertyName("parameterType")]
    public int parameterType { get; set; }
    
    [JsonPropertyName("searchParameters")]
    public string? searchParameters { get; set; }
    
    [JsonPropertyName("currentPage")]
    public int currentPage { get; set; }
    
    [JsonPropertyName("pageSize")]
    public int pageSize { get; set; }

}