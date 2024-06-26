namespace PersonalProtfolio;
using System.Text.Json.Serialization;

public class ProyectToReturn
{
    public int Id { get; set; }
    public string Title {get; set;}
    public string Summary {get; set;}
    public string Content {get; set;}
    public string Technology {get; set;}
    public string? ImagePath {get;set;}

    // cuando me pasen por el body la tecnologia como un numero entero lo convierto en un enum
    [JsonConverter(typeof(JsonStringEnumConverter))]

    public TechnologiesEnum TechnologyEnum { get; set; }


    


}
