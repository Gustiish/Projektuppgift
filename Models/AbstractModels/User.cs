using System.ComponentModel.DataAnnotations.Schema;

namespace Projektuppgift.Models
{
    public abstract class User
    {
        public abstract bool IsAdmin { get;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        [NotMapped]
        public bool IsLoggedIn { get; set; } = false;
    }
}
