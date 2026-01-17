using RentCar.Data.Entities;
using RentCar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;

namespace RentCar.Core
{
    public class ControllerCustomer
    {
        RentCarDbContext dbContext = new RentCarDbContext();
        public async Task InsertCustomer()
        {
            var customer1 =await dbContext.Customers.FirstOrDefaultAsync(x => x.EGN == "09312901");
            if (customer1 == null)
            {
                Customer customer = new Customer()
                {
                    Id = 1,
                    FName = "Carl",
                    LastName = "Hoffmann",
                    EGN = "09312901",
                    Credit_Card_Number = "1234 5678 9000 0000",
                    Email = "Holymann@gmail.com",
                    Phone = "49 6625 811104",
                    City = "Drezden",
                    Country = "Germany"
                };
                await dbContext.Customers.AddAsync(customer);
            }
            var customer2 = await dbContext.Customers.FirstOrDefaultAsync(x => x.EGN == "129874");
            if (customer2 == null)
            {
                Customer customer = new Customer()
                {
                    Id = 2,
                    FName = "Conrad",
                    LastName = "Becker",
                    EGN = "129874",
                    Credit_Card_Number = "1234 5678 9012 3456",
                    Email = "Congey@kahoo.com",
                    Phone = "49 2407 552804",
                    City = "Hamburg",
                    Country = "Germany"
                };
                await dbContext.Customers.AddAsync(customer);
            }
            var customer3 = await dbContext.Customers.FirstOrDefaultAsync(x => x.EGN == "938568");
            if (customer3 == null)
            {
                Customer customer = new Customer()
                {
                    Id = 3,
                    FName = "Ben",
                    LastName = "Muller",
                    EGN = "938568",
                    Credit_Card_Number = "3131 5926 5358 9793",
                    Email = "beMul@abv.de",
                    Phone = "493723 247611",
                    City = "Berlin",
                    Country = "Germany",
                };
                await dbContext.Customers.AddAsync(customer);
            }
            var customer4 = await dbContext.Customers.FirstOrDefaultAsync(x => x.EGN == "1234 2345 4567");
            if (customer4 == null)
            {
                Customer customer = new Customer()
                {
                    Id = 4,
                    FName = "Enzo",
                    LastName = "Ferrari",
                    EGN = "1234 2345 4567",
                    Credit_Card_Number = "5333 6195 0371 5702",
                    Email = "Aerodynamics@red.com",
                    Phone = "123 4567 8901",
                    City = "Rome",
                    Country = "Italy"
                };
                await dbContext.Customers.AddAsync(customer);
            }
            var customer5 =await dbContext.Customers.FirstOrDefaultAsync(x => x.EGN == "8508010133");
            if (customer5 == null)
            {
                Customer customer = new Customer()
                {
                    Id = 5,
                    FName = "Andrea",
                    LastName = "Rossi",
                    EGN = "8508010133",
                    Credit_Card_Number = "4433 3343 3343 3434",
                    Email = "roSSi@gmail.com",
                    Phone = "0456 123 4567",
                    City = "Torino",
                    Country = "Italy"

                };
               await dbContext.Customers.AddAsync(customer);
            }
            var customer6 = await dbContext.Customers.FirstOrDefaultAsync(x => x.EGN == "5843 2166 1964 2184");
            if (customer6 == null)
            {
                Customer customer = new Customer()
                {
                    Id = 6,
                    FName = "Beatrice",
                    LastName = "Bonetti",
                    EGN = "5843 2166 1964 2184",
                    Credit_Card_Number = "4833 1200 3412 3456",
                    Email = "beatrice@gmail.com",
                    Phone = "011 300 123456",
                    City = "Milano",
                    Country = "Italy"
                };
               await dbContext.Customers.AddAsync(customer);
            }
            await dbContext.SaveChangesAsync();
        }
        public async Task<string> AddCustomer(string fname, string lname, string egn,string card,string email,string phone, string city, string country)
        {
            string output = "";
            var lastCustomer =await dbContext.Customers.OrderByDescending(x => x.Id).FirstOrDefaultAsync();

            int lastId = 0;
            if (lastCustomer != null)
            {
                lastId = lastCustomer.Id;
            }
            Customer customer = new Customer()
            {
                Id=lastId+1,
                FName=fname,
                LastName=lname,
                EGN=egn,
                Credit_Card_Number=card,
                Email=email,
                Phone=phone,
                City=city,
                Country=country
            };
           await dbContext.Customers.AddAsync(customer);
            await dbContext.SaveChangesAsync();
           
            output = "You successfully added customer";
            return output;
        }
        public async Task<string> CustomerPhone()
        {
            var customer =await dbContext.Customers.ToListAsync();
            string output = "";
            foreach(var x in customer)
            {
                output += $"--{x.Id}-- {x.FName} {x.LastName} {x.Phone}\n";
            }
            return output;
        }
        public async Task<string> CustomerNewPhone(int cId,string phone)
        {
            string output = "";
            var customer=await dbContext.Customers.Where(x=>x.Id==cId).FirstOrDefaultAsync();
            if(customer==null)
            {
               
                output = $"There is no customer with this id {cId}";
            }
            else
            {
                customer.Phone = phone;
                await dbContext.SaveChangesAsync();
               
                output = "You changed the number successfully";
            }
            return output;
        }
        public async Task<string> ShowEveryCustomer()
        {
            string output = "";
            var customer =await dbContext.Customers.ToListAsync();
            foreach(var x in customer)
            {
                output += $"--{x.Id}--\n {x.FName} {x.LastName}, EGN {x.EGN} {x.Email}, City {x.City}, Country {x.Country}\n";
            }
            return output;
        }
        public async Task<string> RemoveCustomer(int id)
        {
            var customer =await dbContext.Customers.FirstOrDefaultAsync(x => x.Id == id);
            string output;
            if (customer != null)
            {
                dbContext.Customers.Remove(customer);
                await dbContext.SaveChangesAsync();
               
                output = $"You successfully remove {customer.FName} {customer.LastName}";
            }
            else
            {
                
                output = $"There is no customer with this id ";
            }
            return output;
        }
        public async Task<string> ALlCustomers()
        {
            string output = "";
            var customer=await dbContext.Customers.ToListAsync();
            foreach(var x in customer)
            {
                output += $"--{x.Id}-- {x.FName} {x.LastName} {x.EGN}\n";
            }
            return output;
        }
        public async Task<string> CustomerNewCity(int cId,string city)
        {
            string output = "";
            var customer =await dbContext.Customers.Where(x => x.Id == cId).FirstOrDefaultAsync();
            if (customer == null)
            {
               
                output = $"There is no customer with this id {cId}";
            }
            else
            {
                customer.City = city;
                 await dbContext.SaveChangesAsync();
                
                output = "You changed the city successfully";
            }
            return output;
        }
        public async Task<string> CustomerNewCityCountry(int cId, string city,string country)
        {
            string output = "";
            var customer =await dbContext.Customers.Where(x => x.Id == cId).FirstOrDefaultAsync();
            if (customer == null)
            {
               
                output = $"There is no customer with this id {cId}";
            }
            else
            {
                customer.City = city;
                customer.Country = country;
                await dbContext.SaveChangesAsync();
               
                output = "You changed the city and the country successfully";
            }
            return output;
        }
        public async Task<string> CustomerCityCountry()
        {
            string output = "";
            var customer =await dbContext.Customers.ToListAsync();
            foreach (var x in customer)
            {
                output += $"--{x.Id}--\n {x.FName} {x.LastName}, City {x.City}, Country {x.Country}\n";
            }
            return output;
        }
        public async Task<List<int>> FormCustomerId()
        {
            List<int> result = new List<int>();
            var customer=await dbContext.Customers.Select(x=> x.Id).OrderBy(x=>x).ToListAsync();
            foreach(var x in customer)
            {
                result.Add(x);
            }
            return result;
        }
    }
}
