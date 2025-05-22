
using Microsoft.AspNetCore.Mvc.Rendering;
using Projektuppgift.Models;

namespace Projektuppgift.ViewModels
{
    public class CarCreateViewModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public List<string> Images { get; set; }


        public SelectList BrandList { get; set; }
        public SelectList ModelList { get; set; }
    }
}
