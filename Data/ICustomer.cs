using Projektuppgift.Models;

namespace Projektuppgift.Data
{
    public interface ICustomer
    {
        IEnumerable<CarRental> GetCars();
        IEnumerable<Image> ShowPictures(CarRental car);
        CustomerOrder CreateBooking(CarRental car, DateTime startDate, DateTime endDate);

        IEnumerable<CustomerOrder> GetOrders();
        void RemoveOrder (CustomerOrder order);



        

    }
}
