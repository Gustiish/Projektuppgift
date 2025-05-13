using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projektuppgift.Data;
using Projektuppgift.Models;

namespace Projektuppgift.Controllers
{
    public class AdminController
    {
        private readonly IGenericRepository<Admin> admin;
        private readonly ApplicationDbContext context;

        public AdminController(IGenericRepository<Admin> admin, ApplicationDbContext context)
        {
            this.admin = admin;
            this.context = context;
        }

        public ActionResult Index()
        {
            throw new NotImplementedException();
        }





    }
}
