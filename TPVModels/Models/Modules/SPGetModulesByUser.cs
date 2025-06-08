namespace TPVModels.Models.Modules;

public class SPGetModulesByUser
{

    public int idModule { get; set; }

    public string? moduleName { get; set; }

    public string? moduleURL { get; set; }

    public string? moduleIcon { get; set; }

    public int idStatus { get; set; }

    public string? statusDescription { get; set; }

    public DateTime createdAt { get; set; }
    
    public DateTime updatedAt { get; set; }

}