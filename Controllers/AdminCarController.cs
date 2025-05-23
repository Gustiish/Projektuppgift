using Microsoft.AspNetCore.Mvc;
using Projektuppgift.Models;
using Projektuppgift.Data;
using NuGet.Protocol.Core.Types;
using Projektuppgift.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projektuppgift.ViewModels;
using AutoMapper;
using Microsoft.IdentityModel.Tokens;

namespace Projektuppgift.Controllers
{
    public class AdminCarController : Controller
    {
        private readonly IGenericRepository<CarRental> repo;
        private readonly CarService carService = new CarService(); //lägga till via DI??
        private readonly IMapper CreateMapper;
        private readonly IMapper EditMapper;

        public AdminCarController(IGenericRepository<CarRental> repository, IMapper CreateMapper, IMapper EditMapper)
        {
            repo = repository;
            this.CreateMapper = CreateMapper;
            this.EditMapper = EditMapper;
        }

        public ActionResult DisplayCars()
        {
            return View(repo.GetAll());
        }

        public ActionResult Create()
        {
            CarCreateViewModel carVM = new CarCreateViewModel();
            ViewBag.BrandList = new SelectList(CarService.Cars.Keys);
            ViewBag.ModelList = new SelectList(new List<string>());

            return View(carVM);
        }


        [HttpPost]
        public ActionResult Create([Bind("Model, Brand, Images")]CarCreateViewModel modelVM)
        {
            ViewBag.BrandList = new SelectList(CarService.Cars.Keys, modelVM.Brand);

            if (CarService.Cars.ContainsKey(modelVM.Brand))
            {
                ViewBag.ModelList = new SelectList(CarService.Cars[modelVM.Brand]);
            }
            else
            {
                ViewBag.ModelList = new SelectList(new List<string>());
            }

            

            if (ModelState.IsValid)
            {
                CarRental newCar = CreateMapper.Map<CarRental>(modelVM);
                repo.Add(newCar);
                return RedirectToAction("DisplayCars");

                
            }
           

            return View(modelVM);
        }

        public ActionResult Details(int id)
        {
            return View(repo.GetByID(id));
        }

        public ActionResult Edit(int id)
        {
            if (null == repo.GetByID(id) || repo.GetAll().IsNullOrEmpty())
            {
                return NotFound();
            }

            CarEditViewModel modelVM = EditMapper.Map<CarEditViewModel>(repo.GetByID(id));

            ViewBag.Brands = new SelectList(CarService.Cars.Keys);
            ViewBag.Models = new SelectList(new List<string>());


            return View(modelVM);
        }



        [HttpPost]
        public ActionResult Edit(CarEditViewModel car)
        {
            ViewBag.BrandList = new SelectList(CarService.Cars.Keys, car.Brand);

            if (CarService.Cars.ContainsKey(car.Brand))
            {
                ViewBag.ModelList = new SelectList(CarService.Cars[car.Brand]);
            }
            else
            {
                ViewBag.ModelList = new SelectList(new List<string>());
            }

            


            if (ModelState.IsValid)
            {
                
                CarRental carRental = EditMapper.Map<CarRental>(car);
                repo.Update(carRental);
                return RedirectToAction("DisplayCars");
            }

            return View(car);


            


        }

        public ActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
