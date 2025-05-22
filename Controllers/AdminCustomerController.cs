using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Projektuppgift.Data;
using Projektuppgift.Models;
using Projektuppgift.ViewModels;

namespace Projektuppgift.Controllers
{
    public class AdminCustomerController : Controller
    {
        private readonly IGenericRepository<Customer> repo;

        public AdminCustomerController(IGenericRepository<Customer> repository)
        {
            this.repo = repository;
        }


        // GET: AdminCustomerController
        public ActionResult DisplayCustomers()
        {
            return View(repo.GetAll());
        }

        // GET: AdminCustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View(repo.GetByID(id));
        }

        // GET: AdminCustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminCustomerController/Create
        [HttpPost]
      
        public ActionResult Create([Bind(include: "FirstName, LastName, Email, Password")] Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repo.Add(customer);
                    return RedirectToAction("DisplayCustomers");
                }
                else
                {
                    ViewBag.Message = "All forms must be filled";
                    return View(customer);
                }
            }
            catch
            {
                return View(customer);
            }
        }

        // GET: AdminCustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            if (id == null || repo.GetAll().IsNullOrEmpty())
            {
                return NotFound();
            }




            CustomerEditViewModel customerVM = new CustomerEditViewModel();
            customerVM.FirstName = repo.GetByID(id).FirstName;
            customerVM.LastName = repo.GetByID(id).LastName;
            customerVM.Email = repo.GetByID(id).Email;

            return View(customerVM);
        }

        // POST: AdminCustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomerEditViewModel customerVM)
        {
            try
            {
                var customer = repo.GetByID(customerVM.Id);
                if (customer == null)
                {
                    return NotFound();
                } 

                if (!ModelState.IsValid)
                {
                    ViewBag.Message = "Failed to update!";
                    return View();
                }

                
                customer.FirstName = customerVM.FirstName;
                customer.LastName = customerVM.LastName;
                customer.Email = customerVM.Email;



                repo.Update(customer);
                ViewBag.Message = "Successfully updated!";
                return View(customerVM);

            }
            catch
            {
                return View();
            }
        }

        // GET: AdminCustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            var customer = repo.GetByID(id);
            return View(customer);
        }

        // POST: AdminCustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var customer = repo.GetByID(id);
                repo.Delete(customer);
                return RedirectToAction("DisplayCustomers");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult DisplayOptions()
        {
            return View();
        }
    }
}
