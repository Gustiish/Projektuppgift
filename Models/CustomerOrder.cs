using Projektuppgift.Models.AbstractModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projektuppgift.Models;

public class CustomerOrder : IEntity
{
    public int Id { get; set; }
    
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    
    public int CarRentalId { get; set; }
    public CarRental Car { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
