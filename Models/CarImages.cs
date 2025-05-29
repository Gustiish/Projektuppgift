namespace Projektuppgift.Models
{
    public class CarImages
    {
        public int Id { get; set; }
        public string stringURl { get; set; }
        public int CarRentalId  { get; set; }
        public CarRental CarRental { get; set; }
    }
}
