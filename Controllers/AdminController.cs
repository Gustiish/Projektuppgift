using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Projektuppgift.Data;
using Projektuppgift.Models;

namespace Projektuppgift.Controllers
{
    public class AdminController : Controller
    {
        private readonly IGenericRepository<Admin> admin;
        private readonly IGenericRepository<Customer> customer;
        private readonly IGenericRepository<CarRental> cars;
        private readonly IGenericRepository<CustomerOrder> orders;
        private readonly ApplicationDbContext context;

        public AdminController(IGenericRepository<Admin> admin, ApplicationDbContext context, IGenericRepository<Customer> customer, IGenericRepository<CarRental> cars, IGenericRepository<CustomerOrder> orders)
        {
            this.admin = admin;
            this.customer = customer;
            this.cars = cars;
            this.orders = orders;
            this.context = context;
        }

        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Login(string email, string password)
        {
            IEnumerable<Admin> adminData = admin.GetAll();
            try
            {
                foreach (var admin in adminData)
                {
                    if (admin.Email == email && admin.Password == password)
                    {
                        admin.IsLoggedIn = true;
                        return RedirectToAction("DisplayOptions");
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }

        }

        public ActionResult DisplayOptions()
        {
            return View();
        }

        public ActionResult DisplayCustomers()
        {
            IEnumerable<Customer> customers = customer.GetAll();
            
            return View(customers);
        }




    }
}
