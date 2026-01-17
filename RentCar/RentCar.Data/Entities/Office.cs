using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entities
{
    public class Office
    {
        [Key] public int Id { get; set; }
        [Column] public string Name { get; set; }
        [Column] public string Address { get; set; }
        [Column] public string City { get; set; }
        [Column] public string Country { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
