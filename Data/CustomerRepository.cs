using Projektuppgift.Models;

namespace Projektuppgift.Data
{
    public class CustomerRepository : ICustomer
    {
        public CustomerOrder CreateBooking(CarRental car, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CarRental> GetCars()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerOrder> GetOrders()
        {
            throw new NotImplementedException();
        }

        public void RemoveOrder(CustomerOrder order)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Image> ShowPictures(CarRental car)
        {
            throw new NotImplementedException();
        }
    }
}
