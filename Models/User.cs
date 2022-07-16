using System.ComponentModel.DataAnnotations;

public class User{

    [Required]
    public string? UserName {get;set;}

    [Required]
    public string? Email {get;set;}

    [Required]
    public string? PassWord {get;set;}
    
}