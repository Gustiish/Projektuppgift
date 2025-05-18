using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projektuppgift.Data;
using Projektuppgift.Models;

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
        public ActionResult DisplayCustomer()
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
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(include: ("FirstName, LastName, Email, Password"))] Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    repo.Add(customer);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminCustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repo.GetByID(id));
        }

        // POST: AdminCustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind(include: "FirstName, LastName, Email")] Customer customer)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }


                var customerId = repo.GetByID(id);
                customerId.FirstName = customer.FirstName;
                customerId.LastName = customer.LastName;
                customerId.Email = customer.Email;



                repo.Update(customerId);
                return RedirectToAction(nameof(Index));

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
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
