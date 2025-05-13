using Projektuppgift.Models;
namespace Projektuppgift.Data
{
    public interface IAccount<T> where T : class
    {
        bool CheckPassword(string password, T user);
        T RegisterUser(T user);



    }
}
