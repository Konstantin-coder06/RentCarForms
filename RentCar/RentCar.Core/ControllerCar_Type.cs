using RentCar.Data.Entities;
using RentCar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RentCar.Core
{
    public class ControllerCar_Type
    {
        RentCarDbContext dbContext = new RentCarDbContext();
        public async Task InsertCarTypes()
        {
            var type1 =await dbContext.Car_Types.FirstOrDefaultAsync(x => x.Id==1);
            if (type1 == null)
            {


                Car_Type car_Type1 = new Car_Type()
                {
                    Id = 1,
                    IdCar = 1,
                    IdType = 4,
                };
                await dbContext.Car_Types.AddAsync(car_Type1);
            }

            var type2 = await dbContext.Car_Types.FirstOrDefaultAsync(x => x.Id == 2);
            if (type2 == null)
            {


                Car_Type car_Type2 = new Car_Type()
                {
                    Id = 2,
                    IdCar = 2,
                    IdType = 5,
                };
                await dbContext.Car_Types.AddAsync(car_Type2);
            }
            var type3 =await dbContext.Car_Types.FirstOrDefaultAsync(x => x.Id == 3);
            if (type3 == null)
            {


                Car_Type car_Type3 = new Car_Type()
                {
                    Id = 3,
                    IdCar = 2,
                    IdType = 11,
                };
                await dbContext.Car_Types.AddAsync(car_Type3);
            }
            var type4 =await dbContext.Car_Types.FirstOrDefaultAsync(x => x.Id == 4);
            if (type4 == null)
            {


                Car_Type car_Type4 = new Car_Type()
                {
                    Id = 4,
                    IdCar = 3,
                    IdType = 4,
                };
                await dbContext.Car_Types.AddAsync(car_Type4);
            }
            var type5 = await dbContext.Car_Types.FirstOrDefaultAsync(x => x.Id == 5);
            if (type5 == null)
            {


                Car_Type car_Type5 = new Car_Type()
                {
                    Id = 5,
                    IdCar = 3,
                    IdType = 10,
                };
                await dbContext.Car_Types.AddAsync(car_Type5);
            }
            var type6 =await dbContext.Car_Types.FirstOrDefaultAsync(x => x.Id == 6);
            if (type6 == null)
            {


                Car_Type car_Type6 = new Car_Type()
                {
                    Id = 6,
                    IdCar = 4,
                    IdType = 1,
                };
                
                 await dbContext.Car_Types.AddAsync(car_Type6);
            }
            var type7 = await dbContext.Car_Types.FirstOrDefaultAsync(x => x.Id == 7);
            if (type7 == null)
            {


                Car_Type car_Type7 = new Car_Type()
                {
                    Id = 7,
                    IdCar = 5,
                    IdType = 7,
                };
                await dbContext.Car_Types.AddAsync(car_Type7);
            }
            var type8 =await dbContext.Car_Types.FirstOrDefaultAsync(x => x.Id == 8);
            if (type8 == null)
            {


                Car_Type car_Type8 = new Car_Type()
                {
                    Id = 8,
                    IdCar = 5,
                    IdType = 13,
                };
                await dbContext.Car_Types.AddAsync(car_Type8);
            }
            var type9 = await dbContext.Car_Types.FirstOrDefaultAsync(x => x.Id == 9);
            if (type9 == null)
            {


                Car_Type car_Type9 = new Car_Type()
                {
                    Id = 9,
                    IdCar = 6,
                    IdType = 16,
                };
                await dbContext.Car_Types.AddAsync(car_Type9);
            }

         
            await dbContext.SaveChangesAsync();
        }
        public async Task<string> AddCarType(int idCar,int idTYpe)
        {
            string output = "";
            var lastCar =await dbContext.Car_Types.OrderByDescending(x => x.Id).FirstOrDefaultAsync();

            int lastId = 0;
            if (lastCar != null)
            {
                lastId = lastCar.Id;
            }
            Car_Type car_Type = new Car_Type()
            {
                Id = lastId + 1,
                IdCar = idCar,
                IdType = idTYpe,
            };
            await dbContext.Car_Types.AddAsync(car_Type);
            await dbContext.SaveChangesAsync();
           
            output = "You added type to the car successfully";
            return output;
        }
    }
}
