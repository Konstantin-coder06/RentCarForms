using Microsoft.EntityFrameworkCore;
using RentCar.Data;
using RentCar.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Core
{
    public class ControllerAdmin
    {
       RentCarDbContext dbContext=new RentCarDbContext();
        public async Task InsertOneAdmin()
        {
            var admin1=dbContext.Admins.FirstOrDefaultAsync(x=>x.Id==1);
            if (admin1 == null)
            {


                var admin = new Admin()
                {
                    Id = 1,
                    AdminName = "Test",
                    AdminPassword = "Test",
                };
                await dbContext.Admins.AddAsync(admin);
            }
            await dbContext.SaveChangesAsync();
        }
        public async Task<string> Locate(string name, string password)
        {
            var admin=await dbContext.Admins.FirstOrDefaultAsync(x=>x.AdminName == name && x.AdminPassword==password);
            string output = "";
            if(admin == null)
            {
                output = "There is no name and password like that";
            }
            else
            {
                output = "Welcome";
            }
            return output;
        }
    }
}
