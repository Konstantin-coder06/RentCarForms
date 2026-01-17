using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entities
{
    public class Customer
    {
        [Key] public int Id { get; set; }
        [Column] public string FName { get; set; }

        [Column] public string LastName { get; set; }
        [Column] public string EGN { get; set; }
        [Column] public string Credit_Card_Number { get; set; }
        [Column] public string Email { get; set; }
        [Column] public string Phone { get; set; }
        [Column] public string City { get; set; }
        [Column] public string Country { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
    }
}
