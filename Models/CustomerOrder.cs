using Projektuppgift.Models.AbstractModels;

namespace Projektuppgift.Models;

public class CustomerOrder : IEntity
{
    public int Id { get; set; }
    public Customer Customer { get; set; }
    public CarRental Car { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
