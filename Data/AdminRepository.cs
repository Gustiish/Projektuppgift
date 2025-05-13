using Microsoft.VisualStudio.Web.CodeGeneration;
using Projektuppgift.Models;

namespace Projektuppgift.Data
{
    public class AdminRepository : IGenericRepository<Admin>
    {
        private readonly ApplicationDbContext _context;

        public AdminRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public void Add(Admin entity)
        {
            try
            {
                _context.Admins.Add(entity);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        public bool Delete(Admin entity)
        {
            try
            {
                _context.Admins.Remove(entity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public IEnumerable<Admin> GetAll()
        {
            return _context.Admins.OrderBy(a => a.AdminId);
        }

        public Admin GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Admin entity)
        {
            throw new NotImplementedException();
        }
    }
}
