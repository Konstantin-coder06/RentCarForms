using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entities
{
    public class CType
    {
        [Key] public int Id { get; set; }
        [Column] public string Name { get; set; }
        [Column] public string LuxuryLevel { get; set; }
        [Column] public int SeatCapacity { get; set; }
        public ICollection<Car_Type> Car_Types { get; set; }
    }
}
