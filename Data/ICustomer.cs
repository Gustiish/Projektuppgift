using Projektuppgift.Models;

namespace Projektuppgift.Data
{
    public interface ICustomer
    {
        IEnumerable<Car> GetCars();
        IEnumerable<Image> ShowPictures(Car car);
        CustomerOrder CreateBooking(Car car, DateTime startDate, DateTime endDate);

        IEnumerable<CustomerOrder> GetOrders();
        void RemoveOrder (CustomerOrder order);



        

    }
}
