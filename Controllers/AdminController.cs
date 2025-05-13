using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projektuppgift.Data;

namespace Projektuppgift.Controllers
{
    public class AdminController
    {
        private readonly IAdmin admin;
        private readonly ApplicationDbContext context;

        public AdminController(IAdmin admin, ApplicationDbContext context)
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
