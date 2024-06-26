
using Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using PersonalProtfolio;


[ApiController]
[Route("api/Proyect")]
public class ProyectController : ControllerBase
{
    private  readonly ProyectRepository _repo;
    public ProyectController(ProyectRepository pepe)
    {
        _repo = pepe;
    }

    [HttpGet("{idProject}")]
    public ActionResult Get(int idProject)
    {
        var proyectToReturn = _repo.Get(idProject);
        return Ok(proyectToReturn);
    }

    [HttpGet]
    public ActionResult Get()
    {
        var proyects = _repo.GetAll();
        List<ProyectToReturn> proyectsToReturn = new ();
        foreach (var proyect in proyects)
        {
            proyectsToReturn.Add(new ProyectToReturn()
            {
                Id = proyect.Id,
                Title = proyect.Title,
                Summary = proyect.Summary,
                Content = proyect.Content,
                Technology = proyect.Technology,
                ImagePath = proyect.ImagePath,
                TechnologyEnum = proyect.TechnologyEnum
            });
        }
        return Ok(proyectsToReturn);
    }

    [HttpPost]
    public ActionResult AddProject([FromBody] ProyectToAdd body)
    {
        var newProject = new Proyect()
        {
            Content = body.Content,
            State = "Active",
            Date = DateTime.UtcNow,
            ImagePath = body.ImagePath,
            Summary = body.Summary,
            Title = body.Title,
            Technology = body.Technology,
            TechnologyEnum = body.TechnologyEnum

        }; 
        return Ok(_repo.AddProject(newProject));
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteProject(int id)
    {
        return Ok(_repo.Delete(id));;
    }

    [HttpPut("{id}")]
    public ActionResult UpdateProyect(int id, [FromBody] ProyectToUpdate body)
    {
       
        var proyectToReturn = _repo.GetAll().FirstOrDefault(a => a.Id == id);

        proyectToReturn.Content = body.Content;
        proyectToReturn.Summary = body.Summary;
        proyectToReturn.ImagePath = body.ImagePath;
        proyectToReturn.Technology = body.Technology;
        
        _repo.Update(proyectToReturn);
        return Ok();
    }
    //devolver los Articulos coincidencias parciales por titulo o resumen
    [HttpGet ("search")]
    public ActionResult Search([FromQuery] string search)
    {
        var proyectToReturn = _repo.GetAll().Where(a => a.Title.Contains(search) || a.Summary.Contains(search));
        return Ok(proyectToReturn);
        
    }

}