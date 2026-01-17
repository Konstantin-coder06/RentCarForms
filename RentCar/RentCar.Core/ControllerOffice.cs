using RentCar.Data.Entities;
using RentCar.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace RentCar.Core
{
    public class ControllerOffice
    {
        RentCarDbContext dbContext = new RentCarDbContext();
        public async Task InsertOffice()
        {
            var office1 =await dbContext.Offices.FirstOrDefaultAsync(x => x.Id==1);
            if (office1 == null)
            {
                Office office = new Office()
                {
                    Id = 1,
                    Name = "Rent Luxury",
                    Address = "Saarstrasse 17",
                    City = "Berlin",
                    Country = "Germany"
                };
                await dbContext.Offices.AddAsync(office);
            }
            var office2 = await dbContext.Offices.FirstOrDefaultAsync(x => x.Id == 2);
            if (office2 == null)
            {
                Office office = new Office()
                {
                    Id = 2,
                    Name = "Rent Luxury",
                    Address = "Vorbergstrasse 15",
                    City = "Berlin",
                    Country = "Germany"
                };
               await dbContext.Offices.AddAsync(office);
            }
            var office3 =await dbContext.Offices.FirstOrDefaultAsync(x => x.Id==3);
            if (office3 == null)
            {
                Office office = new Office()
                {
                    Id = 3,
                    Name = "Supers Rent",
                    Address = "Battonnstrasse 28",
                    City = "Frankfurt",
                    Country = "Germany"
                };
                await dbContext.Offices.AddAsync(office);
            }
            await dbContext.SaveChangesAsync();
        }
        public async Task< string> ShowAllOffices()
        {
            string output = "";
            var offices =await dbContext.Offices.ToListAsync();
            foreach(var office in offices)
            {
                output += $"--{office.Id}-- {office.Name} {office.Address}\n\n";
            }
            return output;  
        }
        public async Task<string> ShowOfficesDistinct()
        {
            string output = "";
            var offices=await dbContext.Offices.Select(x=>x.Name).Distinct().ToListAsync();
            foreach(var office in offices)
            {
                output += $"{office}\n";
            }
            return output;
        }
        public async Task<string> AddOffice(string name, string address, string city, string country)
        {
            string output = "";
            var lastOffice =await dbContext.Offices.OrderByDescending(x => x.Id).FirstOrDefaultAsync();

            int lastId = 0;
            if (lastOffice != null)
            {
                lastId = lastOffice.Id;
            }
            Office office = new Office()
            {
                Id = lastId+1,
                Name = name,
                Address = address,
                City = city,
                Country = country
            };
            await dbContext.Offices.AddAsync(office);
            await dbContext.SaveChangesAsync();
          
            output = "You successfully add office";
            return output;
        }
        public async Task<string >RemoveOffice(int id)
        {
            var office =await dbContext.Offices.FirstOrDefaultAsync(x => x.Id == id);
            string output;
            if (office != null)
            {
                dbContext.Offices.Remove(office);
                await dbContext.SaveChangesAsync();
               
                output = $"You successfully remove {office.Name}";
            }
            else
            {
              
                output = $"There is no office with this id ";
            }
            return output;

        }
        public async Task<string> ChangeOfficeAddress(int id,string newAddress)
        {
            string output = "";
            var office=await dbContext.Offices.FirstOrDefaultAsync(y => y.Id == id);
            if (office == null)
            {
            
                output = "There is no office with this id";
            }
            else
            {
                office.Address = newAddress;
                await dbContext.SaveChangesAsync();
               
                output = $"You successfully changed the address to {newAddress}";
            }
            return output;
        }
        public async Task<string> ChangeOfficeCity(int id, string city)
        {
            string output = "";
            var office =await dbContext.Offices.Where(y => y.Id == id).FirstOrDefaultAsync();
            if (office == null)
            {
              
                output = "There is no office with this id";
            }
            else
            {
                office.City = city;
                await dbContext.SaveChangesAsync();
              
                output = $"You successfully changed the address to {city}";
            }
            return output;
        }
        public async Task<string> ChangeOfficeCityCountry(int id, string city,string country)
        {
            string output = "";
            var office =await dbContext.Offices.Where(y => y.Id == id).FirstOrDefaultAsync();
            if (office == null)
            {
             
                output = "There is no office with this id";
            }
            else
            {
                office.City = city;
                office.Country = country;
                await dbContext.SaveChangesAsync();
               
                output += $"You successfully changed the address to {city} {country}";
            }
            return output;
        }
        public async Task<string> ShowAllOfficesCityCountry()
        {
            string output = "";
            var offices =await dbContext.Offices.ToListAsync();
            foreach (var office in offices)
            {
                output += $"--{office.Id}-- {office.Name} {office.Address} {office.City} {office.Country}\n\n";
            }
            return output;
        }
        public async Task<List<int>> FormIdOffice()
        {
            List<int> list = new List<int>();  
            var offices=await dbContext.Offices.Select(y => y.Id).ToListAsync();         
            foreach(var x in offices)
            {
                list.Add(x);
            }       
            return list;

        }
        public async Task<List<string>> FormNameOffice()
        {
            List<string> list = new List<string>();
            var offices = await dbContext.Offices.Select(y => y.Name).Distinct().ToListAsync();
            foreach (var x in offices)
            {
                list.Add(x);
            }
            return list;

        }
    }
}
