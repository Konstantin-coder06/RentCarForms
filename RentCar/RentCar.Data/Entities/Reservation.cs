using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entities
{
    public class Reservation
    {
        [Key] public int Id { get; set; }
        [Column] public DateTime Start_Date { get; set; }
        [Column] public DateTime End_Date { get; set; }
        [Column] public string Start_LocationCity { get; set; }
        [Column] public string Start_LocationAddress { get; set; }
        [Column] public string End_LocationCity { get; set; }
        [Column] public string End_LocationAddress { get; set; }
        [ForeignKey("Car")]
        public int Car_Id { get; set; }
        public Car Car { get; set; }
        [ForeignKey("Customer")]
        public int Customer_id { get; set; }
        public Customer Customer { get; set; }
    }
}
