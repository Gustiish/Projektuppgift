using Projektuppgift.Models.AbstractModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projektuppgift.Models;

public class CarRental: IEntity
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }

    public bool IsBooked { get; set; } = false;
    public List<string>? Image { get; set; }
    public CustomerOrder? CustomerOrder { get; set; }
    [ForeignKey("CustomerOrder")]
    public int? CustomerOrderId { get; set; }
}
