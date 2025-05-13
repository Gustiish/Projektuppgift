namespace Projektuppgift.Models
{
    public class CustomerOrder
    {
        public int customerOrderId { get; set; }
        public Customer Customer { get; set; }
        public Car Car { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
