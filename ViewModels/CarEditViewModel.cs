using Projektuppgift.Models;

namespace Projektuppgift.ViewModels
{
    public class CarEditViewModel
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public List<string>? Images { get; set; }
        public bool IsBooked { get; set; } = false;
        public CustomerOrder? customerOrder { get; set; }
        public int? CustomerOrderId { get; set; }
    }
}
