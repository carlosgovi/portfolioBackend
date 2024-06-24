using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Proyect
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [MaxLength(70)]
    public string Title {get; set;}
    [MaxLength(230)]
    public string Summary {get; set;}
    public string? Description { get; set; }
    public string? Technology { get; set; }
    public string Content {get; set;}
    public DateTime Date {get;set;}
    public string? ImagePath {get;set;}
    
    public string State {get; set;} = "Active";


    }