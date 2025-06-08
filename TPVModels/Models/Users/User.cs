namespace TPVModels.Models.Users;

public class User
{

    
    public int idUser { get; set; }

    public string? authToken { get; set; }
    
    public string userName { get; set; }
    
    public string? userEmail { get; set; }

    public string? userPassword { get; set; }

    public int idStatus { get; set; }

    public DateTime createdAt { get; set; }

    public DateTime updatedAt { get; set; }
    
}