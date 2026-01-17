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
    public class ControllerCType
    {
        RentCarDbContext dbContext = new RentCarDbContext();
        public async Task InsertType()
        {
            var ctype1 = await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "Sedan" && x.SeatCapacity == 4 && x.LuxuryLevel == "III");
            if (ctype1 == null)
            {


                CType type1 = new CType()
                {
                    Id = 1,
                    Name = "Sedan",
                    SeatCapacity = 4,
                    LuxuryLevel = "III"
                };
                await dbContext.Types.AddAsync(type1);
            }
            var ctype2 =await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "Sedan" && x.SeatCapacity == 4 && x.LuxuryLevel == "II");
            if (ctype2 == null)
            {


                CType type2 = new CType()
                {
                    Id = 2,
                    Name = "Sedan",
                    SeatCapacity = 4,
                    LuxuryLevel = "II"
                };
                await dbContext.Types.AddAsync(type2);
            }
            var ctype3 = await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "Sedan" && x.SeatCapacity == 4 && x.LuxuryLevel == "I");
            if (ctype3 == null)
            {


                CType type3 = new CType()
                {
                    Id = 3,
                    Name = "Sedan",
                    SeatCapacity = 4,
                    LuxuryLevel = "I"
                };
                await dbContext.Types.AddAsync(type3);
            }
            var ctype4 = await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "Coupe" && x.SeatCapacity == 2 && x.LuxuryLevel == "III");
            if (ctype4 == null)
            {


                CType type4 = new CType()
                {
                    Id = 4,
                    Name = "Coupe",
                    SeatCapacity = 2,
                    LuxuryLevel = "III"
                };
                await dbContext.Types.AddAsync(type4);
            }
            var ctype5 =await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "Coupe" && x.SeatCapacity == 2 && x.LuxuryLevel == "II");
            if (ctype5 == null)
            {


                CType type5 = new CType()
                {
                    Id = 5,
                    Name = "Coupe",
                    SeatCapacity = 2,
                    LuxuryLevel = "II"
                };
                await dbContext.Types.AddAsync(type5);
            }
            var ctype6 =await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "Coupe" && x.SeatCapacity == 2 && x.LuxuryLevel == "I");
            if (ctype6 == null)
            {


                CType type6 = new CType()
                {
                    Id = 6,
                    Name = "Coupe",
                    SeatCapacity = 2,
                    LuxuryLevel = "I"
                };
                
                await dbContext.Types.AddAsync(type6);
            }
            var ctype7 = await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "Grand Coupe" && x.SeatCapacity == 4 && x.LuxuryLevel == "III");
            if (ctype7 == null)
            {


                CType type7 = new CType()
                {
                    Id = 7,
                    Name = "Grand Coupe",
                    SeatCapacity = 4,
                    LuxuryLevel = "III"
                };
                await dbContext.Types.AddAsync(type7);
            }
            var ctype8 = await  dbContext.Types.FirstOrDefaultAsync(x => x.Name == "Grand Coupe" && x.SeatCapacity == 4 && x.LuxuryLevel == "II");
            if (ctype8 == null)
            {


                CType type8 = new CType()
                {
                    Id = 8,
                    Name = "Grand Coupe",
                    SeatCapacity = 4,
                    LuxuryLevel = "II"
                };
                await dbContext.Types.AddAsync(type8);
            }
            var ctype9 =await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "Grand Coupe" && x.SeatCapacity == 4 && x.LuxuryLevel == "I");
            if (ctype9 == null)
            {


                CType type9 = new CType()
                {
                    Id = 9,
                    Name = "Grand Coupe",
                    SeatCapacity = 4,
                    LuxuryLevel = "I"
                };
                await dbContext.Types.AddAsync(type9);
            }
            var ctype10 =await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "Convertable" && x.SeatCapacity == 2 && x.LuxuryLevel == "III");
            if (ctype10 == null)
            {


                CType type10 = new CType()
                {
                    Id = 10,
                    Name = "Convertable",
                    SeatCapacity = 2,
                    LuxuryLevel = "III"
                };
                await dbContext.Types.AddAsync(type10);
            }
            var ctype11 = await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "Convertable" && x.SeatCapacity == 2 && x.LuxuryLevel == "II");
            if (ctype11 == null)
            {


                CType type11 = new CType()
                {
                    Id = 11,
                    Name = "Convertable",
                    SeatCapacity = 2,
                    LuxuryLevel = "II"
                };
                await dbContext.Types.AddAsync(type11);
            }
            var ctype12 = await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "Convertable" && x.SeatCapacity == 2 && x.LuxuryLevel == "I");
            if (ctype12 == null)
            {


                CType type12 = new CType()
                {
                    Id = 12,
                    Name = "Convertable",
                    SeatCapacity = 2,
                    LuxuryLevel = "I"
                };
                await dbContext.Types.AddAsync(type12);
            }
            var ctype13 =await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "Convertable" && x.SeatCapacity == 4 && x.LuxuryLevel == "III");
            if (ctype13 == null)
            {


                CType type13 = new CType()
                {
                    Id = 13,
                    Name = "Convertable",
                    SeatCapacity = 4,
                    LuxuryLevel = "III"
                };
                await dbContext.Types.AddAsync(type13);
            }
            var ctype14 = await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "Convertable" && x.SeatCapacity == 4 && x.LuxuryLevel == "II");
            if (ctype14 == null)
            {


                CType type14 = new CType()
                {
                    Id = 14,
                    Name = "Convertable",
                    SeatCapacity = 4,
                    LuxuryLevel = "II"
                };
                await dbContext.Types.AddAsync(type14);
            }
            var ctype15 = await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "Convertable" && x.SeatCapacity == 4 && x.LuxuryLevel == "I");
            if (ctype15 == null)
            {


                CType type15 = new CType()
                {
                    Id = 15,
                    Name = "Convertable",
                    SeatCapacity = 4,
                    LuxuryLevel = "I"
                };
                await dbContext.Types.AddAsync(type15);
            }
            var ctype16 = await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "SUV" && x.SeatCapacity == 5 && x.LuxuryLevel == "III");
            if (ctype16 == null)
            {


                CType type16 = new CType()
                {
                    Id = 16,
                    Name = "SUV",
                    SeatCapacity = 5,
                    LuxuryLevel = "III"
                };
                await dbContext.Types.AddAsync(type16);
            }
            var ctype17 =await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "SUV" && x.SeatCapacity == 5 && x.LuxuryLevel == "II");
            if (ctype17 == null)
            {


                CType type17 = new CType()
                {
                    Id = 17,
                    Name = "SUV",
                    SeatCapacity = 5,
                    LuxuryLevel = "II"
                };
                await dbContext.Types.AddAsync(type17);
            }
            var ctype18 =await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "SUV" && x.SeatCapacity == 5 && x.LuxuryLevel == "I");
            if (ctype18 == null)
            {


                CType type18 = new CType()
                {
                    Id = 18,
                    Name = "SUV",
                    SeatCapacity = 5,
                    LuxuryLevel = "I"
                };
                await dbContext.Types.AddAsync(type18);
            }
            var ctype19 =await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "SUV" && x.SeatCapacity == 7 && x.LuxuryLevel == "III");
            if (ctype19 == null)
            {


                CType type19 = new CType()
                {
                    Id = 19,
                    Name = "SUV",
                    SeatCapacity = 7,
                    LuxuryLevel = "III"
                };
                await dbContext.Types.AddAsync(type19);
            }
            var ctype20 = await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "SUV" && x.SeatCapacity == 7 && x.LuxuryLevel == "II");
            if (ctype20 == null)
            {


                CType type20 = new CType()
                {
                    Id = 20,
                    Name = "SUV",
                    SeatCapacity = 7,
                    LuxuryLevel = "II"
                };
                await dbContext.Types.AddAsync(type20);
            }
            var ctype21 =await dbContext.Types.FirstOrDefaultAsync(x => x.Name == "SUV" && x.SeatCapacity == 7 && x.LuxuryLevel == "I");
            if (ctype21 == null)
            {


                CType type21 = new CType()
                {
                    Id = 21,
                    Name = "SUV",
                    SeatCapacity = 7,
                    LuxuryLevel = "I"
                };
                await dbContext.Types.AddAsync(type21);
            }

            await dbContext.SaveChangesAsync();
        }
        public async Task<string> ShowTypes()
        {
            string output = "";
            var types =await dbContext.Types.ToListAsync();
            foreach ( var type in types )
            {
                output += $"--{type.Id}-- {type.Name}, Seats: {type.SeatCapacity}, Luxury {type.LuxuryLevel}\n";
            }
            return output;
        }
        public async Task<string> AddType(string name, int seats, string luxury)
        {
            string output = "";
            var lastType = await dbContext.Types.OrderByDescending(x => x.Id).FirstOrDefaultAsync();

            int lastId = 0;
            if (lastType != null)
            {
                lastId = lastType.Id;
            }
            CType cType = new CType()
            {
                Id = lastId + 1,
                Name = name,
                SeatCapacity = seats,
                LuxuryLevel = luxury
            };
            await dbContext.Types.AddAsync(cType);
            await dbContext.SaveChangesAsync();
            Console.ForegroundColor = ConsoleColor.Green;
            output = "The type is added successfully";
            return output;
        }
        public async Task<string> RemoveType(int id)
        {
            var type =await dbContext.Types.FirstOrDefaultAsync(x => x.Id == id);
            string output;
            if (type != null)
            {
                dbContext.Types.Remove(type);
                await dbContext.SaveChangesAsync();
               
                output = $"You successfully remove {type.Name}";
            }
            else
            {
               
                output = $"There is no like this type";
            }
            return output;
        }
        public async Task< List<int>> FormIdType()
        {
            List<int> list=new List<int>();
            var types= await dbContext.Types.Select(x=>x.Id).OrderBy(x=>x).ToListAsync();
            foreach ( var type in types )
            {
                list.Add(type);
            }
            return list;
        }
    }
}
