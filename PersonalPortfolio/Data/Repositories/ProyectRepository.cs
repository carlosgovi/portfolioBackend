
using System.Reflection.PortableExecutable;

namespace Data.Repositories{
    public class ProyectRepository
    {
        
        private readonly ApplicationContext _context;
        public ProyectRepository( ApplicationContext context)
        {
            _context = context;
           

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
