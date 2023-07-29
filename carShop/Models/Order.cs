using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace carShop.Models
{
    public class Order
    {
        public Order(int id, string phone, string city, string address, DateTime date)
        {
            Id = id;
            Phone = phone;
            City = city;
            Address = address;
            Date = date;
        }

        public string Phone { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int Id { get; set; }
        public DateTime Date { get; set; }
    }
}
