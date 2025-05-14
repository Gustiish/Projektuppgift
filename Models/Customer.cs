using Projektuppgift.Models.AbstractModels;

namespace Projektuppgift.Models
{
    public class Customer : User, IEntity
    {
        public int Id { get; set; }
        
        public override bool IsAdmin { get { return false; } }

    }
}
