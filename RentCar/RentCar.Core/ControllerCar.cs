using Microsoft.EntityFrameworkCore;
using RentCar.Data;
using RentCar.Data.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace RentCar.Core
{
    public class ControllerCar
    {
        RentCarDbContext dbContext = new RentCarDbContext();
        public async Task InsertCar()
        {
            var car1 =await dbContext.Cars.FirstOrDefaultAsync(x => x.Registration_Plate == "M CI 3221");
            if (car1 == null)
            {
                Car car = new Car()
                {
                    Id = 1,
                    Brand = "BMW",
                    Model = "M4Csl",
                    Year = 2023,
                    Color = "Satanic Black",
                    Registration_Plate = "M CI 3221",
                    LuggageCapacity = 440,
                    FuelConsuption = 10.2,
                    Power = 550,
                    Transmition = "eight-speed automatic transmission",
                    Rating = 6.7,
                    Price = 740,
                    IsElectric = false,
                    Office_Id = 3
                };
                await dbContext.Cars.AddAsync(car);
            }
            var car2 =await dbContext.Cars.FirstOrDefaultAsync(x => x.Registration_Plate == "LB 640CS");
            if (car2 == null)
            {
                Car car = new Car()
                {
                    Id = 2,
                    Brand = "Lamborghini",
                    Model = "Huracan Evo Spyder",
                    Year = 2021,
                    Color = "Red",
                    Registration_Plate = "LB 640CS",
                    LuggageCapacity = 150,
                    FuelConsuption = 14,

                    Power = 640,

                    Transmition = "seven-speed dual-clutch",
                    Rating = 6.7,
                    Price = 940,
                    IsElectric = false,
                    Office_Id = 3
                };
                await dbContext.Cars.AddAsync(car);
            }
            var car3 =await dbContext.Cars.FirstOrDefaultAsync(x => x.Registration_Plate == "CB 8380 TP");
            if (car3 == null)
            {
                Car car = new Car()
                {
                    Id = 3,
                    Brand = "Ferrari",
                    Model = "F8 Spider",
                    Year = 2021,
                    Color = "Black",
                    Registration_Plate = "CB 8380 TP",
                    LuggageCapacity = 200,
                    FuelConsuption = 14.2,
                    Power = 720,
                    Transmition = "seven-speed dual clutch",
                    Rating = 6.7,
                    Price = 997,
                    IsElectric = false,
                    Office_Id = 3
                };
                await dbContext.Cars.AddAsync(car);
            }
            var car4 =await dbContext.Cars.FirstOrDefaultAsync(x => x.Registration_Plate == "S EQ297BE");
            if (car4 == null)
            {
                Car car = new Car()
                {
                    Id = 4,
                    Brand = "Mercedes",
                    Model = "EQS 580",
                    Year = 2022,
                    Color = "Dark Blue",
                    Registration_Plate = "S EQ297BE",
                    LuggageCapacity = 610,
                    FuelConsuption = null,
                    Power = 535,
                    Transmition = "one speed",
                    Rating = 6.7,
                    Price = 254,
                    IsElectric = true,
                    Office_Id = 1
                };
                await dbContext.Cars.AddAsync(car);
            }
            var car5 = await dbContext.Cars.FirstOrDefaultAsync(x => x.Registration_Plate == "W 55 BML");
            if (car5 == null)
            {
                Car car = new Car()
                {
                    Id = 5,
                    Brand = "Bentley",
                    Model = "Continental Convertable",
                    Year = 2022,
                    Color = "Grey",
                    Registration_Plate = "W 55 BML",
                    LuggageCapacity = 358,
                    FuelConsuption = 13.7,
                    Power = 550,
                    Transmition = "eight-speed ZF transmission",
                    Rating = 6.7,
                    Price = 769,
                    IsElectric = false,
                    Office_Id = 2
                };
                await dbContext.Cars.AddAsync(car);
            }
            var car6 = await dbContext.Cars.FirstOrDefaultAsync(x => x.Registration_Plate == "R RR 761");
            if (car6 == null)
            {
                Car car = new Car()
                {
                    Id = 6,
                    Brand = "Rolls-Royce",
                    Model = "Cullinan",
                    Year = 2021,
                    Color = "Grey",
                    Registration_Plate = "R RR 761",
                    LuggageCapacity = 560,
                    FuelConsuption = 16.1,
                    Power = 600,
                    Transmition = "eight-speed 8HP automatic",
                    Price = 1225,
                    Rating = 6.7,
                    Office_Id = 1
                };
               await dbContext.Cars.AddAsync(car);
            }
            await dbContext.SaveChangesAsync();
        }
        public async Task<string> ShowAllCarFromAllOffices()
        {
            string output="";
            var car = await dbContext.Cars.ToListAsync();
            foreach(var x in car)
            {
                output += $"--{x.Brand} {x.Model}-- \n   Color: {x.Color}\n   Year: {x.Year}\n   Reg. plate: {x.Registration_Plate}\n   Luggage cap.: {x.LuggageCapacity}\n   Consumption: {x.FuelConsuption}\n   HP: {x.Power}\n   Transmition: {x.Transmition}\n   Price per one day: {x.Price}\n   Rating: {x.Rating}\n\n";
            }
            return output;
        }
        public async Task<string> ShowAllCarFromOneOffice(int officeID)
        {
            string output = "";
            var car = await dbContext.Cars.Where(x => x.Office_Id == officeID).ToListAsync();
            foreach(var x in car)
            {
                output += $"--{x.Brand} {x.Model}-- \n  Color: {x.Color}\n   Year: {x.Year}\n   Reg. plate: {x.Registration_Plate}\n   Luggage cap.: {x.LuggageCapacity}\n   Consumption: {x.FuelConsuption}\n   HP: {x.Power}\n   Transmition {x.Transmition}\n   Price per one day {x.Price}\n Rating {x.Rating}\n\n";
            }
            if (string.IsNullOrWhiteSpace(output))
            {
              
                output += "There is no car in this office";
            }
            return output;
        }
        public async Task<string> ShowAllCarFromOffices(string office)
        {
            string output = "";
            var car = await dbContext.Cars.Where(x => x.Office.Name == office).ToListAsync();
            foreach (var x in car)
            {
                output += $"--{x.Brand} {x.Model}-- \n  Color: {x.Color}\n   Year: {x.Year}\n   Reg. plate: {x.Registration_Plate}\n   Luggage cap.: {x.LuggageCapacity}\n   Consumption: {x.FuelConsuption}\n   HP: {x.Power}\n   Transmition {x.Transmition}\n   Price per one day {x.Price}\n Rating {x.Rating}\n\n";
            }
            if (string.IsNullOrWhiteSpace(output))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                output += "There is no car in this office";
            }
            return output;
        }
        public async Task<string> ShowSedan()
        {
            string output = "";
            var cars =await dbContext.Cars
                   .Include(c => c.Types)
                   .ThenInclude(cm => cm.CType)
                   .ToListAsync();
            foreach (var car in cars)
            {
                foreach (var carModification in car.Types.Where(c=>c.IdType==1 || c.IdType==2 || c.IdType==3))
                {                 
                    output += $"--{car.Brand} {car.Model}--\n   Type: {carModification.CType.Name}\n   Luxury Level: {carModification.CType.LuxuryLevel}\n   Seat capacity: {carModification.CType.SeatCapacity}\n\n";
                }
            }
            if (string.IsNullOrWhiteSpace(output))
            {
              
                output += "There is no cars with this type now";
            }          
            return output;
        }
        public async Task<string> ShowCoupe()
        {
            string output = "";
            var cars = await dbContext.Cars
                   .Include(c => c.Types)
                   .ThenInclude(cm => cm.CType)
                   .ToListAsync();
            foreach (var car in cars)
            {
                foreach (var carModification in car.Types.Where(c => c.IdType == 4 || c.IdType == 5 || c.IdType == 6))
                {
                    output += $"--{car.Brand} {car.Model}--\n   Type: {carModification.CType.Name}\n   Luxury Level: {carModification.CType.LuxuryLevel}\n   Seat capacity: {carModification.CType.SeatCapacity}\n\n";
                }
            }
            if (string.IsNullOrWhiteSpace(output))
            {
              
                output += "There is no cars with this type now";              
            }
            return output;
        }
        public async Task<string> ShowGrandCoupe()
        {
            string output = "";
            var cars =await dbContext.Cars
                   .Include(c => c.Types)
                   .ThenInclude(cm => cm.CType)
                   .ToListAsync();
            foreach (var car in cars)
            {
                foreach (var carModification in car.Types.Where(c => c.IdType == 7 || c.IdType == 8 || c.IdType == 9))
                {
                    output += $"--{car.Brand} {car.Model}--\n   Type: {carModification.CType.Name}\n   Luxury Level: {carModification.CType.LuxuryLevel}\n   Seat capacity: {carModification.CType.SeatCapacity}\n\n";
                }
            }
            if (string.IsNullOrWhiteSpace(output))
            {
               
                output += "There is no cars with this type now";                
            }
            return output;
        }
        public async Task<string> ShowConvertable2()
        {
            string output = "";
            var cars = await dbContext.Cars
                   .Include(c => c.Types)
                   .ThenInclude(cm => cm.CType)
                   .ToListAsync();
            foreach (var car in cars)
            {
                foreach (var carModification in car.Types.Where(c => c.IdType == 10 || c.IdType == 11 || c.IdType == 12))
                {
                    output += $"--{car.Brand} {car.Model}--\n   Type: {carModification.CType.Name}\n   Luxury Level: {carModification.CType.LuxuryLevel}\n   Seat capacity: {carModification.CType.SeatCapacity}\n\n";
                }
            }
            if (string.IsNullOrWhiteSpace(output))
            {
               
                output += "There is no cars with this type now";              
            }
            return output;
        }
        public async Task<string> ShowConvertable4()
        {
            string output = "";
            var cars = await dbContext.Cars
                   .Include(c => c.Types)
                   .ThenInclude(cm => cm.CType)
                   .ToListAsync();
            foreach (var car in cars)
            {
                foreach (var carModification in car.Types.Where(c => c.IdType == 13 || c.IdType == 14 || c.IdType == 15))
                {
                    output += $"--{car.Brand} {car.Model}--\n   Type: {carModification.CType.Name}\n   Luxury Level: {carModification.CType.LuxuryLevel}\n Seat capacity: {carModification.CType.SeatCapacity}\n\n";
                }
            }
            if (string.IsNullOrWhiteSpace(output))
            {
               
                output += "There is no cars with this type now";               
            }
            return output;
        }
        public async Task<string> ShowSUV5()
        {
            string output = "";
            var cars = await dbContext.Cars
                   .Include(c => c.Types)
                   .ThenInclude(cm => cm.CType)
                   .ToListAsync();
            foreach (var car in cars)
            {
                foreach (var carModification in car.Types.Where(c => c.IdType == 16 || c.IdType == 17 || c.IdType == 18))
                {
                    output += $"--{car.Brand} {car.Model}--\n   Type: {carModification.CType.Name}\n   Luxury Level: {carModification.CType.LuxuryLevel}\n   Seat capacity: {carModification.CType.SeatCapacity}\n\n";
                }
            }
            if (string.IsNullOrWhiteSpace(output))
            {
               
                output += "There is no cars with this type now";              
            }
            return output;
        }
        public async Task<string> ShowSUV7()
        {
            string output = "";
            var cars =await dbContext.Cars
                   .Include(c => c.Types)
                   .ThenInclude(cm => cm.CType)
                   .ToListAsync();
            foreach (var car in cars)
            {
                foreach (var carModification in car.Types.Where(c => c.IdType == 19 || c.IdType == 20 || c.IdType == 21))
                {
                    output += $"--{car.Brand} {car.Model}--\n   Type: {carModification.CType.Name}\n   Luxury Level: {carModification.CType.LuxuryLevel}\n   Seat capacity: {carModification.CType.SeatCapacity}\n\n";
                }
            }
            if (string.IsNullOrWhiteSpace(output))
            {
               
                output += "There is no cars with this type now";             
            }
            return output;
        }
        public async Task<string> ShowSpecifiedPrice(double min, double max)
        {
            var car= await dbContext.Cars.Where(x=>x.Price>=min && x.Price<=max).ToListAsync();
            string output = "";
            foreach(var x in car)
            {
                output += $"--{x.Brand} {x.Model}-- \n   Color: {x.Color}\n   Year: {x.Year}\n   Reg. plate: {x.Registration_Plate}\n   Luggage cap.: {x.LuggageCapacity}\n   Consumption: {x.FuelConsuption}\n   HP: {x.Power}\n   Transmition: {x.Transmition}\n   Price per one day: {x.Price}\n   Rating: {x.Rating}\n\n";
            }
            if (string.IsNullOrWhiteSpace(output))
            {
              
                output += "There is no cars.";
            }
            return output;
        }
        public async Task<string> ShowBrands()
        {
            var car= await dbContext.Cars.Select(x=>x.Brand).Distinct().ToListAsync();
            string output = "";
            foreach(var x in car)
            {
                output += $"{x}\n";
            }          
            return output;
        }
        public async Task<string> ShowBrandsAndModels()
        {
            var carBrand = await dbContext.Cars.ToListAsync();
            string output = "";
            foreach (var x in carBrand)
            {              
                output += $"--{x.Id}-- {x.Brand} {x.Model}\n";
            }         
            return output;
        }
        public async Task<string> ShowOneBrand(string brand)
        {
            var car= await dbContext.Cars.Where(x=>x.Brand==brand).ToListAsync();
            string output = "";
            foreach (var x in car)
            {
                output += $"--{x.Brand} {x.Model}-- \n   Color: {x.Color}\n   Year: {x.Year}\n   Reg. plate: {x.Registration_Plate}\n   Luggage cap.: {x.LuggageCapacity}\n   Consumption: {x.FuelConsuption}\n   HP: {x.Power}\n   Transmition: {x.Transmition}\n   Price per one day: {x.Price}\n Rating: {x.Rating}\n\n";
            }
            if (string.IsNullOrWhiteSpace(output))
            {
               
                output += "There is no cars with this brand now";
            }
            return output;
        }
        public async Task<string> AddCar(string brand,string model,int year, string color,string plate, int capacity,bool electric, double consumption,int power, string transmition,double Price,int officeId)
        {
            string output = "";
            var lastCar =await dbContext.Cars.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            int lastId = 0;
            if (lastCar != null)
            {
                lastId = lastCar.Id;
            }
            Car car = new Car()
            {
                Id= lastId+1,
                Brand=brand,
                Model=model,
                Year=year,
                Color=color,
                Registration_Plate=plate,
                LuggageCapacity=capacity,
                IsElectric=electric,
                FuelConsuption=consumption,
                Power=power,
                Transmition=transmition,
                Price=Price,
                Office_Id=officeId
            };
            await dbContext.Cars.AddAsync(car);
            await dbContext.SaveChangesAsync();
            
            output= $"Car {car.Brand} {car.Model} added successfully.";           
            return output;
        }
        public async Task<string> AddElectricCar(string brand, string model, int year, string color, string plate, int capacity, bool electric, int power, string transmition, double Price,int officeId)
        {
            string output = "";
            var lastCar = await dbContext.Cars.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            int lastId = 0;
            if (lastCar != null)
            {
                lastId = lastCar.Id;
            }
            Car car = new Car()
            {
                Id = lastId + 1,
                Brand = brand,
                Model = model,
                Year = year,
                Color = color,
                Registration_Plate = plate,
                LuggageCapacity = capacity,
                IsElectric = electric,              
                Power = power,
                Transmition = transmition,
                Price = Price,
                Office_Id=officeId               
            };
            await dbContext.Cars.AddAsync(car);
            await dbContext.SaveChangesAsync();
           
            output = $"The car {car.Brand} {car.Model} added successfully.";          
            return output;
        }
        public async Task<string> CarsOFfice()
        {
            string output = "";
            var car= await dbContext.Cars.ToListAsync();
            
            foreach(var x in car)
            {
                var offices = await dbContext.Offices.Where(y => y.Id ==x.Office_Id).ToListAsync();
                foreach (var off in offices)
                {
                    output += $"--{x.Id}-- {x.Brand} {x.Model} - Office: № {x.Office_Id}, Name {off.Name}\n";
                }
            }
            return output;
        }
        public async Task<string> MoveCarOffice(int idcar, int idoffice)
        {
            var car = await dbContext.Cars.FirstOrDefaultAsync(x => x.Id == idcar);
            var lastid=await dbContext.Offices.Select(x=>x.Id).OrderByDescending(x=> x).FirstOrDefaultAsync();
            string output = "";
            if (car.Office_Id == idoffice)
            {
              
                output += "This car is already in this office";
            }
            if (lastid < idoffice)
            {
               
                output += $"There is no office id like {idoffice}";
            }
            else
            {
                car.Office_Id = idoffice;
                
                await dbContext.SaveChangesAsync();
                output += $"You successfully changed the office of the car {car.Brand} {car.Model}";
            }
            return output;
        }
        public async Task<string> CarRating()
        {
            string output = "";
            var car =await dbContext.Cars.ToListAsync();
            foreach (var x in car)
            {
                output += $"--{x.Id}-- {x.Brand} {x.Model} Rating {x.Rating}\n";
            }
            return output;
        }
        public async Task<string> CarUpdateRating(int carId, double rating)
        {
            string output = "";
            var car= await dbContext.Cars.FirstOrDefaultAsync(x=>x.Id==carId);
            if (rating > 10.0 || rating < 0.0)
            {
              
                output += "You cannot add rating greater than 10 or lower than 0!";
            }
            else
            {


                if (car.Rating == rating)
                {
                   
                    output += "The car already has this rating";
                }
                else
                {
                    car.Rating = rating;
                    await dbContext.SaveChangesAsync();
                   
                    output += $"You changed the rating to {rating} for {car.Brand} {car.Model}";
                }
            }
            
            return output;
        }
        public async Task<string> ShowAllCarFromAllOfficesId()
        {
            string output = "";
            var car =await dbContext.Cars.ToListAsync();
            foreach (var x in car)
            {
                output += $"--{x.Id}-- {x.Brand} {x.Model}-- \n   Color: {x.Color}\n   Year: {x.Year}\n   Reg. plate: {x.Registration_Plate}\n   Luggage cap.: {x.LuggageCapacity}\n   Consumption: {x.FuelConsuption}\n   HP: {x.Power}\n   Transmition: {x.Transmition}\n   Price per one day: {x.Price}\n   Rating: {x.Rating}\n\n";
            }
            return output;
        }
        public async Task<string> RemoveCar(int id)
        {
            var car = await dbContext.Cars.FirstOrDefaultAsync(x=> x.Id==id);
            string output;
            if (car != null)
            {
                dbContext.Cars.Remove(car);
                await dbContext.SaveChangesAsync();
             
                output = $"You successfully remove {car.Brand} {car.Model}";
            }
            else
            {
              
                output = $"There is no like this car";               
            }
            return output;
        }
        public async Task< List<string>> FormShowBrands()
        {
            var car = await dbContext.Cars.Select(x => x.Brand).Distinct().ToListAsync();
            List<string> output = new List<string>();
            foreach (var x in car)
            {
                output.Add(x);
            }
            return output;
        }
        public async Task< List<int>> FormShowCarsId()
        {
            var car =await dbContext.Cars.Select(x => x.Id).OrderBy(x=>x).ToListAsync();
            List<int> output = new List<int>();
            foreach (var x in car)
            {
                output.Add(x);
            }
            return output;
        }
        public async Task<double> PricePerOneDayCarId(int carId)
        {
            double price =await dbContext.Cars.Where(x => x.Id == carId).Select(x => x.Price).FirstOrDefaultAsync();
            return price;
        }
        public async Task<string> AllCombitionEngine()
        {
            string output="";
            var car =await dbContext.Cars.Where(x => x.IsElectric == false).ToListAsync();
            foreach(var x in car)
            {
                output+=$"--{x.Brand} {x.Model}--\n    Color: {x.Color}\n   Year: {x.Year}\n   Reg. plate: {x.Registration_Plate}\n   Luggage cap.: {x.LuggageCapacity}\n   Consumption: {x.FuelConsuption}\n   HP: {x.Power}\n   Transmition: {x.Transmition}\n   Price per one day: {x.Price}\n   Rating: {x.Rating}\n\n";
            }
            if (output == null)
            {
                output = "There is no combition engine cars now.";
            }
            return output;
        }
        public async Task<string> AllElectric()
        {
            string output = "";
            var car = await dbContext.Cars.Where(x => x.IsElectric == true).ToListAsync();
            foreach (var x in car)
            {
                output += $"--{x.Brand} {x.Model}--\n    Color: {x.Color}\n   Year: {x.Year}\n   Reg. plate: {x.Registration_Plate}\n   Luggage cap.: {x.LuggageCapacity}\n   HP: {x.Power}\n   Transmition: {x.Transmition}\n   Price per one day: {x.Price}\n   Rating: {x.Rating}\n\n";
            }

            if (output == null)
            {
                output = "There is no electric cars now.";
            }
            return output;
        }
    }
   
}