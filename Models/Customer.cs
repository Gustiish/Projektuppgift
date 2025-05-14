using Projektuppgift.Models.AbstractModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projektuppgift.Models
{
    public class Customer : User, IEntity
    {
        public int Id { get; set; }

        [ForeignKey("CustomerOrder")]
        public int? CustomerOrderId { get; set; }
        
        //navigation 
        public CustomerOrder? CustomerOrder { get; set; }
        public override bool IsAdmin { get { return false; } }

     

    }
}
