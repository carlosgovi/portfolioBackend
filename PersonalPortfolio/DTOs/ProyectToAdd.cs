using System.Text.Json.Serialization;
using PersonalProtfolio;

public class ProyectToAdd
{
    public string Title {get; set;}
    public string Summary {get; set;}
    public string Content {get; set;}
    public string Technology {get; set;}
    public string? ImagePath {get;set;}

    public TechnologiesEnum TechnologyEnum { get; set; }


    
}