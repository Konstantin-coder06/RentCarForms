using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entities
{
    public class Car_Type
    {
        [Key] public int Id { get; set; }
        [ForeignKey("Car")]
        public int IdCar { get; set; }
        public Car Car { get; set; }

        [ForeignKey("CType")]
        public int IdType { get; set; }
        public CType CType { get; set; }
    }
}
