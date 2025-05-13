using Projektuppgift.Models;

namespace Projektuppgift.Data
{
    public class AdminRepository : IAdmin
    {
        private readonly ApplicationDbContext _context;

        public AdminRepository(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
        }
        public void AddCar(CarRental car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
        }

        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }


        public void DeleteOrder(CustomerOrder customerOrder)
        {
            _context.CustomerOrders.Remove(customerOrder);
            _context.SaveChanges();
        }

        public CarRental GetCarById(int carId)
        {
            return _context.Cars.FirstOrDefault(x => x.CarRentalId == carId);
        }

        public IEnumerable<CarRental> GetCars()
        {
            return _context.Cars.OrderBy(c => c.CarRentalId);
        }

        public Customer GetCustomerById(int customerId)
        {
            return _context.Customers.FirstOrDefault(c => c.CustomerId == customerId);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return _context.Customers.OrderBy(c => c.CustomerId);
        }

        public IEnumerable<CustomerOrder> GetOrders()
        {
            return _context.CustomerOrders.OrderBy(co => co.customerOrderId);
        }


        public void RemoveCar(CarRental car)
        {
            
            _context.Cars.Remove(car);
            _context.SaveChanges();
        }



        public void RemoveCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }



        public void UpdateCar(CarRental car)
        {
            _context.Cars.Update(car);
            _context.SaveChanges();
        }


        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
    }
}
