namespace Projektuppgift.Models
{
    public class Admin : User
    {
        public int AdminId { get; set; }

        public override bool IsAdmin { get { return true; } }

    }
}
