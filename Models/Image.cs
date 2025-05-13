using System.ComponentModel.DataAnnotations.Schema;

namespace Projektuppgift.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string URL { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
