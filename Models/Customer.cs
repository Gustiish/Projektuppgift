namespace Projektuppgift.Models
{
    public class Customer : User
    {
        public int CustomerId { get; set; }
        
        public override bool IsAdmin { get { return false; } }

    }
}
