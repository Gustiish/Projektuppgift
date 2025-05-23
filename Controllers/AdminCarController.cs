using Microsoft.AspNetCore.Mvc;
using Projektuppgift.Models;
using Projektuppgift.Data;
using NuGet.Protocol.Core.Types;
using Projektuppgift.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projektuppgift.ViewModels;
using AutoMapper;

namespace Projektuppgift.Controllers
{
    public class AdminCarController : Controller
    {
        private readonly IGenericRepository<CarRental> repo;
        private readonly CarService carService = new CarService(); //lägga till via DI??
        private readonly IMapper mapper;

        public AdminCarController(IGenericRepository<CarRental> repository, IMapper mapper)
        {
            repo = repository;
            this.mapper = mapper;
        }

        public ActionResult DisplayCars()
        {
            return View(repo.GetAll());
        }

        public ActionResult Create()
        {
            CarCreateViewModel carVM = new CarCreateViewModel();
            carVM.BrandList = new SelectList(CarService.Cars.Keys);
            carVM.ModelList = new SelectList(new List<string>());

            return View(carVM);
        }


        [HttpPost]
        public ActionResult Create([Bind("Model, Brand, Images")]CarCreateViewModel modelVM)
        {
            modelVM.BrandList = new SelectList(CarService.Cars.Keys, modelVM.Brand);

            if (CarService.Cars.ContainsKey(modelVM.Brand))
            {
                modelVM.ModelList = new SelectList(CarService.Cars[modelVM.Brand]);
            }
            else
            {
                modelVM.ModelList = new SelectList(new List<string>());
            }

            

            if (ModelState.IsValid)
            {
                CarRental newCar = mapper.Map<CarRental>(modelVM);
                repo.Add(newCar);
                return RedirectToAction("DisplayCars");

                
            }
            foreach (var key in ModelState.Keys)
            {
                var state = ModelState[key];
                foreach (var error in state.Errors)
                {
                    Console.WriteLine($"{key}: {error.ErrorMessage}");
                }
            }



            return View(modelVM);



        }




    }
}
