using Projektuppgift.Models.AbstractModels;

namespace Projektuppgift.Models
{
    public class Admin : User, IEntity
    {
        public int Id { get; set; }

        public override bool IsAdmin { get { return true; } }

        
    }
}
