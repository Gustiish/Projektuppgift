using Projektuppgift.Models;

namespace Projektuppgift.Data
{
    public interface IAdmin
    {

        IEnumerable<Car> GetCars();

        void AddCar(Car car);
        void RemoveCar(Car car);
        void UpdateCar(Car car);
        Car GetCarById(int carId);

        IEnumerable<Customer> GetCustomers();
        void AddCustomer(Customer customer);
        void RemoveCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        Customer GetCustomerById(int customerId);

        IEnumerable<CustomerOrder> GetOrders();
        void DeleteOrder(CustomerOrder customerOrder);



    }
}
