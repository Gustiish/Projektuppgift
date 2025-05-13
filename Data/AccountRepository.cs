using Projektuppgift.Models;
namespace Projektuppgift.Data
{
    public class AccountRepository : IAccount<User>
    {
        public bool CheckPassword(string password, User user)
        {
            try
            {
                if (user.Password == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error" + ex.Message);
            }
            return false;
        }

        public User RegisterUser(User user)
        {
            
        }
    }
}
