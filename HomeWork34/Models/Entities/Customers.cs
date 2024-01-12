using System.ComponentModel.DataAnnotations;
using System;

namespace HomeWork34.Models.Entities
{
    public class Customers
    {
        [Key]
        public int CustomerID { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Adres { get; set; }
        public int SponsorID { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}
