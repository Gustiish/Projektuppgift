
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Projektuppgift.Models;

namespace Projektuppgift.ViewModels
{
    public class CarCreateViewModel
    {
        
        public string Brand { get; set; }
        public string Model { get; set; }
        public List<string> Images { get; set; }

        
    }
}
