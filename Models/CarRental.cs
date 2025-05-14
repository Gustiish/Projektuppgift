using Projektuppgift.Models.AbstractModels;

namespace Projektuppgift.Models;

public class CarRental: IEntity
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }

    public bool IsBooked { get; set; }
    public List<Image> Image { get; set; }
}
