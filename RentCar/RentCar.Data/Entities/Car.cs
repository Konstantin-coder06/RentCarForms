using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entities
{
    public class Car
    {
        [Key] public int Id { get; set; }
        [Column] public string Brand { get; set; }
        [Column] public string Model { get; set; }
        [Column] public int Year { get; set; }
        [Column] public string Color { get; set; }
        [Column] public string Registration_Plate { get; set; }
        [Column] public int LuggageCapacity { get; set; }
        [Column] public double? FuelConsuption { get; set; }

        [Column] public int Power { get; set; }

        [Column] public string Transmition { get; set; }
        [Column] public double Price { get; set; }
        [Column] public double Rating { get; set; }
        [Column] public bool IsElectric { get; set; }
        [ForeignKey("Office")]
        public int Office_Id { get; set; }
        public Office Office { get; set; }

        public ICollection<Car_Type> Types { get; set; }
    }
}
