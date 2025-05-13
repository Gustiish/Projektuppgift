using Projektuppgift.Models;

namespace Projektuppgift.Data
{
    public interface IAdmin
    {

        IEnumerable<CarRental> GetCars();

        void AddCar(CarRental car);
        void RemoveCar(CarRental car);
        void UpdateCar(CarRental car);
        CarRental GetCarById(int carId);

        IEnumerable<Customer> GetCustomers();
        void AddCustomer(Customer customer);
        void RemoveCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        Customer GetCustomerById(int customerId);

        IEnumerable<CustomerOrder> GetOrders();
        void DeleteOrder(CustomerOrder customerOrder);



    }
}
