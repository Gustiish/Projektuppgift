namespace Projektuppgift.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public bool IsBooked { get; set; }
        public List<Image> Image { get; set; }
    }
}
