using RentCar.Data.Entities;
using RentCar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using System.Collections;

namespace RentCar.Core
{
    public class ControllerReservation
    {
        RentCarDbContext dbContext = new RentCarDbContext();
        public async Task InsertReservation()
        {
            var res1 =await dbContext.Reservations.FirstOrDefaultAsync(x => x.Id == 1);
            var reservation1 =await dbContext.Reservations.Where(r => r.Car_Id == 1 &&
                  ((r.Start_Date <= new DateTime(2023, 12, 8) && r.End_Date >= new DateTime(2023, 12, 9) ||
                   (r.Start_Date <= new DateTime(2023, 12, 9) && r.End_Date >= new DateTime(2023, 12, 9)) ||
                   (r.Start_Date >= new DateTime(2023, 12, 8) && r.End_Date <= new DateTime(2023, 12, 9))))).FirstOrDefaultAsync();
            if (res1 == null)
            {
                if (reservation1 == null)
                {
                    Reservation reservation = new Reservation()
                    {
                        Id = 1,
                        Start_Date = new DateTime(2023, 12, 10),
                        End_Date = new DateTime(2023, 12, 11),
                        Start_LocationAddress = "Saarstrasse 17",
                        End_LocationAddress = "Koenigsallee",
                        Start_LocationCity = "Berlin",
                        End_LocationCity = "Berlin",
                        Car_Id = 1,
                        Customer_id = 1,
                    };
                    await dbContext.Reservations.AddAsync(reservation);
                }
                else
                {
                    var car = await dbContext.Cars.FirstOrDefaultAsync(x => x.Id == 1);
                    
                    throw new ArgumentException($"The car {car.Brand} {car.Model} is already reserved for the selected period.");
                }
            }
            var res2 = await dbContext.Reservations.FirstOrDefaultAsync(x => x.Id == 2);
            var reservation2 =await dbContext.Reservations.Where(r => r.Car_Id == 1 &&
                  ((r.Start_Date <= new DateTime(2023, 12, 15) && r.End_Date >= new DateTime(2023, 12, 17) ||
                   (r.Start_Date <= new DateTime(2023, 12, 17) && r.End_Date >= new DateTime(2023, 12, 17)) ||
                   (r.Start_Date >= new DateTime(2023, 12, 15) && r.End_Date <= new DateTime(2023, 12, 17))))).FirstOrDefaultAsync();
            if (res2 == null)
            {
                if (reservation2 == null)
                {
                    Reservation reservation = new Reservation()
                    {
                        Id = 2,
                        Start_Date = new DateTime(2023, 12, 15),
                        End_Date = new DateTime(2023, 12, 17),
                        Start_LocationAddress = "Saarstrasse 17",
                        End_LocationAddress = "Kronprinzessinnenweg 154-150",
                        Start_LocationCity = "Berlin",
                        End_LocationCity = "Berlin",
                        Car_Id = 1,
                        Customer_id = 1,
                    };
                    await dbContext.Reservations.AddAsync(reservation);

                }
                else
                {
                    var car =await dbContext.Cars.FirstOrDefaultAsync(x => x.Id == 1);
                   
                    throw new ArgumentException($"The car {car.Brand} {car.Model} is already reserved for the selected period.");
                    
                }
            }
            /*var res3 = dbContext.Reservations.FirstOrDefault(x => x.Id == 3);
            var reservation3 = dbContext.Reservations.Where(r => r.Car_Id == 1 &&
                  ((r.Start_Date <= new DateTime(2023, 12, 15) && r.End_Date >= new DateTime(2023, 12, 17) ||
                   (r.Start_Date <= new DateTime(2023, 12, 17) && r.End_Date >= new DateTime(2023, 12, 17)) ||
                   (r.Start_Date >= new DateTime(2023, 12, 15) && r.End_Date <= new DateTime(2023, 12, 17))))).FirstOrDefault();
            if (res3 == null)
            {
                if (reservation3 == null)
                {
                    Reservation reservation = new Reservation()
                    {
                        Id = 2,
                        Start_Date = new DateTime(2023, 12, 15),
                        End_Date = new DateTime(2023, 12, 17),
                        Start_LocationAddress = "Saarstrasse 17",
                        End_LocationAddress = "Kronprinzessinnenweg 154-150",
                        Start_LocationCity = "Berlin",
                        End_LocationCity = "Berlin",
                        Car_Id = 1,
                        Customer_id = 1,
                    };
                    dbContext.Reservations.Add(reservation);

                }
                else
                {
                    var car = dbContext.Cars.FirstOrDefault(x => x.Id == 1);
             Console.ForegroundColor = ConsoleColor.DarkRed;
                    throw new ArgumentException($"The car {car.Brand} {car.Model} is already reserved for the selected period.");
                }
            }*/
            await dbContext.SaveChangesAsync();
        }
        public async Task<string> AddReservation(DateTime start, DateTime end, string startLoc, string endLoc, string startCity, string endCity, int carId, int custId)
        {
            string output = "";
            var lastRes =await dbContext.Reservations.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            var reservation = await dbContext.Reservations.Where(r => r.Car_Id == carId &&
                ((r.Start_Date <= start && r.End_Date >= end ||
                 (r.Start_Date <= end  && r.End_Date >= end) ||
                 (r.Start_Date >= start && r.End_Date <= end)))).FirstOrDefaultAsync();
            int lastId = 0;
            if (lastRes != null)
            {
                lastId = lastRes.Id;
            }
            if (reservation == null)
            {


                Reservation reservations = new Reservation()
                {
                    Id = lastId + 1,
                    Start_Date = start,
                    End_Date = end,
                    Start_LocationAddress = startLoc,
                    End_LocationAddress = endLoc,
                    Start_LocationCity = startCity,
                    End_LocationCity = endCity,
                    Car_Id = carId,
                    Customer_id = custId,

                };
                await dbContext.Reservations.AddAsync(reservations);
                await dbContext.SaveChangesAsync();
               
                output = $"You successfully added reservation for {start} {end}";
            }
            else
            {
                var car = await dbContext.Cars.FirstOrDefaultAsync(x => x.Id == carId);
               
                output = $"The car {car.Brand} {car.Model} is already reserved for the selected period.";
            }
            return output;
        }
        public async Task<string> ReservationsForCustomer(int idcust)
        {
            string output = "";
            var reservations= await dbContext.Reservations.Where(x => x.Customer_id == idcust).ToListAsync();
            foreach(var x in reservations) 
            {
                var cars=await dbContext.Cars.Where(y=>y.Id==x.Car_Id).ToListAsync();
                foreach (var y in cars)
                {


                    output += $"--{x.Id}--\nFrom: {x.Start_Date} to {x.End_Date}\n From address: {x.Start_LocationAddress} to {x.End_LocationAddress}\n From city: {x.Start_LocationCity} to {x.End_LocationCity}\n Car: {y.Brand} {y.Model}\n\n";
                }
            }
            if (string.IsNullOrWhiteSpace(output))
            {
               
                output += "This customer don't have reservation/s";
            }
            return output;
        }
        public async Task<List<int>> LoadReservationsForCustomer(int idcust)
        {
            List<int> output = new List<int>();
            var reservations =await dbContext.Reservations.Where(x => x.Customer_id == idcust).ToListAsync();
            foreach (var x in reservations)
            {
                var cars =await dbContext.Cars.Where(y => y.Id == x.Car_Id).ToListAsync();
                foreach (var y in cars)
                {

                    output.Add(x.Id);
                }
            }
          
            return output;
        }
        public async Task<string> RemoveReservation(int id)
        {
            var reservations=await dbContext.Reservations.FirstOrDefaultAsync(x=>x.Id==id);
            string output = "";
            if(reservations != null)
            {
                dbContext.Reservations.Remove(reservations);
                await dbContext.SaveChangesAsync();
              
                output = "You remove the reservation";
            }
            else
            {
               
                output = "There is no reservation with this id";
                
            }
            return output;
        }
        public async Task<string> ChangeStartDate(int id,DateTime newStart)
        {
            var reser = await dbContext.Reservations.FirstOrDefaultAsync(y => y.Id == id);
            string output = "";

            if (reser == null)
            {
               
                output = "There is no reservation with this id";
            }
            else
            {
               
                int carid = reser.Car_Id;

                
                var overlappingReservation = await dbContext.Reservations
                    .Where(r => r.Car_Id == carid && r.Id != id && r.Start_Date < reser.End_Date && newStart < r.End_Date)
                    .FirstOrDefaultAsync();

                if (newStart >= reser.End_Date)
                {
                    
                    output = "Start date cannot be the same as or later than the end date";
                }
                else if (overlappingReservation != null)
                {
                    output = $"There is an overlapping reservation with this car until {overlappingReservation.End_Date}";
                }
                else
                {
                  
                    reser.Start_Date = newStart;
                    await dbContext.SaveChangesAsync();
                   
                    output = "You changed the start date successfully";
                }
            }

            return output;
        }
        public async Task<string> ChangeEndDate(int id, DateTime newEnd)
        {
            var reser = await dbContext.Reservations.FirstOrDefaultAsync(y => y.Id == id);
            string output = "";

            if (reser == null)
            {
              
                output = "There is no reservation with this id";
            }
            else
            {
               
                var carid = reser.Car_Id;

              
                var overlappingReservation = await dbContext.Reservations
                    .Where(r => r.Car_Id == carid && r.Id != id && r.Start_Date < newEnd && newEnd > r.Start_Date)
                    .FirstOrDefaultAsync();

                if (newEnd <= reser.Start_Date)
                {
                   
                    output = "End date cannot be the same as or earlier than the start date";
                }
                else if (overlappingReservation != null)
                {
                    output = $"There is an overlapping reservation with this car starting from {overlappingReservation.Start_Date}";
                }
                else
                {
                  
                    reser.End_Date = newEnd;
                    await dbContext.SaveChangesAsync();
                   
                    output = "You changed the end date successfully";
                }
            }

            return output;
        }
    }
}
