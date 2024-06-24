
using System.Reflection.PortableExecutable;

namespace Data.Repositories{
    public class ProyectRepository
    {
        // public List<Article> Articles;
        private readonly ApplicationContext _context;
        public ProyectRepository( ApplicationContext context)
        {
            _context = context;
            // Articles = new List<Article>() 
            // {
            //     new Article(){Id=1, Content="content1fsdfsdfsdfsdfsdf", Summary="this is a summary of the content1", Title="First Article"},
            //     new Article(){Id=2, Content="content2fsdfsdfsdfsdfsdf", Summary="this is a summary of the content2", Title="Second Article"},
            //     new Article(){Id=3, Content="content3fsdfsdfsdfsdfsdf", Summary="this is a summary of the content3", Title="Third Article"},
            //     new Article(){Id=4, Content="content4fsdfsdfsdfsdfsdf", Summary="this is a summary of the content4", Title="Fourth Article"}
            // };

        }

        public int AddProject(Proyect newProyect)
        {
            _context.Proyects.Add(newProyect);
            _context.SaveChanges();
            return newProyect.Id;
        }

        public Proyect Update(Proyect proyectToUpdate)
        {
            _context.Proyects.Update(proyectToUpdate);
            _context.SaveChanges();
            return proyectToUpdate;
        }

        public List<Proyect> GetAll()
        {
            return _context.Proyects.Where(a => a.State == "Active").ToList();
         
        }

        public Proyect? Get(int Id)
        {
            return _context.Proyects.Where(a => a.State == "Active").FirstOrDefault(a => a.Id == Id);
           
        }

        public bool Delete(int id)
        {
            var proyectToDelete = _context.Proyects.FirstOrDefault(a => a.Id == id);
            if(proyectToDelete is not null)
            {
                
                proyectToDelete.State = "Deleted";

                _context.Proyects.Update(proyectToDelete);

                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
