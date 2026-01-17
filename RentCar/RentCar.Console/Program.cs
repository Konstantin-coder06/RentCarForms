// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient.Server;
using RentCar.Core;
using RentCar.Data.Entities;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading.Channels;

int CalculateDays(DateTime start, DateTime end)
{
    TimeSpan difference = end - start;
    return difference.Days;
}
ControllerOffice controllerOffice = new ControllerOffice();
await controllerOffice.InsertOffice();
ControllerCar controllerCar = new ControllerCar();
await controllerCar.InsertCar();
ControllerCType controllerCType = new ControllerCType();
await controllerCType.InsertType();
ControllerCar_Type controllerCar_Type = new ControllerCar_Type();
await controllerCar_Type.InsertCarTypes();

ControllerCustomer customer = new ControllerCustomer();
await customer.InsertCustomer();

ControllerReservation reservation = new ControllerReservation();
await reservation.InsertReservation();
ControllerAdmin admin = new ControllerAdmin();
await admin.InsertOneAdmin();
string yesNo;
Console.ForegroundColor = ConsoleColor.Cyan;
string s = "Welcome to 'DriveTime rentals'";
Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
Console.WriteLine(s);
do
{

    Console.WriteLine("\r\nDo you want to enter as admin? Y/N");
    yesNo = Console.ReadLine();
    if (yesNo != "Y" && yesNo != "N")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid operation");
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
}
while (yesNo != "Y" && yesNo != "N");
if (yesNo == "N")
{

    while (true)
    {
        try
        {
            Console.WriteLine("\r\nPlease select a functionality below by writing the number before the option");         
            Console.WriteLine("1. Show all cars from all the offices");
            Console.WriteLine("2. Show all cars from only one office");
            Console.WriteLine("3. Show all cars from offices with same name");
            Console.WriteLine("4. Show all combition engine cars");
            Console.WriteLine("5. Show all electric cars");
            Console.WriteLine("6. Show Sedan");
            Console.WriteLine("7. Show Two-Seater' Coupe");
            Console.WriteLine("8. Show Four-Seater' Coupe");
            Console.WriteLine("9. Show Two-Seater' Convertable");
            Console.WriteLine("10. Show Four-Seater' Convertable");
            Console.WriteLine("11. Show Five-Seater SUV"); 
            Console.WriteLine("12. Show Seven-Seater SUV");
            Console.WriteLine("13. Show cars with price typed by you");
            Console.WriteLine("14. Show only one brand cars typed by you");
            Console.WriteLine("15. Make Reservation");
            Console.WriteLine("16. Exit");
            string[] input = Console.ReadLine().Split(' ');
            string option = input[0];
            if(int.Parse(option)<=0 || int.Parse(option) > 16)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid operation");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if(int.Parse(option) == 1)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string inf= await controllerCar.ShowAllCarFromAllOffices();
                Console.WriteLine(inf);
                Console.ForegroundColor=ConsoleColor.Cyan;
            }
            if(int.Parse(option) == 2)
            {
                Console.WriteLine("\nChoose from these by typing the id");
                Console.ForegroundColor = ConsoleColor.White;
                string infOff=await controllerOffice.ShowAllOffices();           
                Console.WriteLine(infOff);
                Console.ForegroundColor = ConsoleColor.Cyan;
                int id = int.Parse(Console.ReadLine());
                Console.ForegroundColor= ConsoleColor.White;
                string inf = await controllerCar.ShowAllCarFromOneOffice(id);
                if(inf== "There is no car in this office")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(inf);
                }
                else
                {
                    Console.WriteLine(inf);
                }              
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if (int.Parse(option) == 3)
            {
                Console.WriteLine("\nChoose from these by typing the name of the office");
                Console.ForegroundColor = ConsoleColor.White;
                string infOff = await controllerOffice.ShowOfficesDistinct();
                Console.WriteLine(infOff);
                Console.ForegroundColor = ConsoleColor.Cyan;
                string  name = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                string inf = await controllerCar.ShowAllCarFromOffices(name);
                if (inf == "There is no car in this office")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(inf);
                }
                else
                {
                    Console.WriteLine(inf);
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if(int.Parse(option)==4)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string inf = await controllerCar.AllCombitionEngine();
                if (inf == "There is no combition engine cars now.")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(inf);
                }
                else
                {
                    Console.WriteLine(inf);
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if (int.Parse(option) == 5)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string inf = await controllerCar.AllElectric();
                if (inf == "There is no electric cars now.")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(inf);
                }
                else
                {
                    Console.WriteLine(inf);
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if (int.Parse(option) == 6)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string inf = await controllerCar.ShowSedan();
                if (inf == "There is no cars with this type now")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(inf);
                }
                else
                {
                    Console.WriteLine(inf);
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if (int.Parse(option) == 7)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string inf = await controllerCar.ShowCoupe();
                if (inf == "There is no cars with this type now")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(inf);
                }
                else
                {
                    Console.WriteLine(inf);
                }
               
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if (int.Parse(option) == 8)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string inf = await controllerCar.ShowGrandCoupe();
                if (inf == "There is no cars with this type now")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(inf);
                }
                else
                {
                    Console.WriteLine(inf);
                }
               
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if (int.Parse(option) == 9)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string inf = await controllerCar.ShowConvertable2();
                if (inf == "There is no cars with this type now")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(inf);
                }
                else
                {
                    Console.WriteLine(inf);
                }
                
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if (int.Parse(option) == 10)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string inf = await controllerCar.ShowConvertable4();
                if (inf == "There is no cars with this type now")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(inf);
                }
                else
                {
                    Console.WriteLine(inf);
                }
               
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if (int.Parse(option) == 11)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string inf = await controllerCar.ShowSUV5();
                if (inf == "There is no cars with this type now")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(inf);
                }
                else
                {
                    Console.WriteLine(inf);
                }
               
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if (int.Parse(option) == 12)
            {
                Console.ForegroundColor = ConsoleColor.White;
                string inf = await controllerCar.ShowSUV7();
                if (inf == "There is no cars with this type now")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(inf);
                }
                else
                {
                    Console.WriteLine(inf);
                }
               
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if(int.Parse(option) == 13)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Min price:");
                int min=int.Parse(Console.ReadLine());
                Console.Write("Max price:");
                int max = int.Parse(Console.ReadLine());
                string inf = await controllerCar.ShowSpecifiedPrice(min, max);

                if (inf == "There is no cars.")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(inf);
                }
                else
                {
                    Console.WriteLine(inf);
                }
                Console.ForegroundColor= ConsoleColor.Cyan;
            }
            if (int.Parse(option) == 14)
            {
                Console.WriteLine("\nChoose from these by typing the name of the brand");
                Console.ForegroundColor = ConsoleColor.White;
                string inf = await controllerCar.ShowBrands();
                Console.WriteLine(inf);
                string brand=Console.ReadLine();
                string output = await controllerCar.ShowOneBrand(brand);
                if (output == "There is no cars.")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(output);
                }
                else
                {
                    Console.WriteLine(output);
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            //ALOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO
            if(int.Parse(option)==15)
            {
                  
                    Console.WriteLine("To add reservation you must enter:");
                    Console.Write("Start date: ");
                    DateTime start = DateTime.Parse(Console.ReadLine());
                    Console.Write("End date: ");
                    DateTime end = DateTime.Parse(Console.ReadLine());
                    Console.Write("Start Location: ");
                    string startLoc = Console.ReadLine();
                    Console.Write("End Location: ");
                    string endLoc = Console.ReadLine();
                    Console.Write("Start City: ");
                    string startCity = Console.ReadLine();
                    Console.Write("End City:");
                    string endCity = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    string allcars = await controllerCar.ShowAllCarFromAllOfficesId();
                    Console.WriteLine(allcars);
                    Console.Write("\nChoose Car Id:");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    int carId = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                    string allCustomers = await customer.ALlCustomers();
                    Console.WriteLine(allCustomers);
                    Console.Write("\nChoose Customer Id: ");
                    int customerid = int.Parse(Console.ReadLine());
                double price = await controllerCar.PricePerOneDayCarId(carId);
                int days = CalculateDays(start,end);
                double total = price * days;
                Console.WriteLine($"It will cost {total}. Do you want to make the reservation? Y/N");
                string yesNoRes;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    yesNoRes = Console.ReadLine();
                    if (yesNoRes == "Y")
                    {

                        string addRes = await reservation.AddReservation(start, end, startLoc, endLoc, startCity, endCity, carId, customerid);
                        if (addRes == $"You successfully added reservation for {start} {end}")
                        {


                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(addRes);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(addRes);
                        }
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    if (yesNoRes == "N")
                    {

                    }
                    if (yesNoRes != "Y" && yesNoRes != "N")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid operation");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                }
                while (yesNoRes != "Y" && yesNoRes != "N");
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            if (int.Parse(option) == 16)
            {
                
                return;
            }
        }
        catch(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red; 
            Console.WriteLine(e.Message);
            Console.ForegroundColor= ConsoleColor.Cyan;
        }
    }
}
if (yesNo == "Y")
{
    Console.Write("Username: ");
    string username = Console.ReadLine();
    Console.Write("Password: ");
    string password = Console.ReadLine();
    string iscorrect = await admin.Locate(username, password);
    if (iscorrect == "There is no name and password like that")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid operation");
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
    else
    {
        while (true)
        {
      
            try
            {



                Console.WriteLine("\r\nPlease select a functionality below by writing the number before the option");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Remove");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Exit");
                int input = int.Parse(Console.ReadLine());
                if (input <= 0 || input >= 5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid operation");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                if (input == 1)
                {
                    Console.WriteLine("What do you want to add");
                    Console.WriteLine("1. Car");
                    Console.WriteLine("2. Car to Type");
                    Console.WriteLine("3. Car Type");
                    Console.WriteLine("4. Customer");
                    Console.WriteLine("5. Office");
                    Console.WriteLine("6. Reservation");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("To add car you must enter:");
                            Console.Write("Brand: ");
                            string brand = Console.ReadLine();
                            Console.Write("Model: ");
                            string model = Console.ReadLine();
                            Console.Write("Year: ");
                            int year = int.Parse(Console.ReadLine());
                            Console.Write("Color: ");
                            string color = Console.ReadLine();
                            Console.Write("Reg. plate: ");
                            string regPlate = Console.ReadLine();
                            Console.Write("Luggage capacity: ");
                            int cap = int.Parse(Console.ReadLine());
                            Console.Write("*True or false\nElectric: ");
                            bool electric = bool.Parse(Console.ReadLine());
                            double consumption = 0;
                            if (electric == false)
                            {

                                Console.Write("Fuel consumption: ");
                                consumption = double.Parse(Console.ReadLine());
                            }
                            Console.Write("Horse power: ");
                            int power = int.Parse(Console.ReadLine());
                            Console.Write("Transmition: ");
                            string transmittion = Console.ReadLine();
                            Console.Write("Price: ");
                            double Price = double.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.White;
                            string infOffice = await controllerOffice.ShowAllOffices();
                            Console.WriteLine(infOffice);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Office in which the car will be: ");
                            int optionOffice = int.Parse(Console.ReadLine());
                            if (electric == false)
                            {
                                string inf = await controllerCar.AddCar(brand, model, year, color, regPlate, cap, electric, consumption, power, transmittion, Price, optionOffice);
                               
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(inf);
                            }
                            if (electric == true)
                            {
                                
                                string inf = await controllerCar.AddElectricCar(brand, model, year, color, regPlate, cap, electric, power, transmittion, Price, optionOffice);
                                Console.ForegroundColor= ConsoleColor.Green;
                                Console.WriteLine(inf);
                            }
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            break;
                        case 2:
                            Console.WriteLine("Choose one car to add it' type");
                            Console.ForegroundColor = ConsoleColor.White;
                            string inf2 = await controllerCar.ShowBrandsAndModels();
                            Console.WriteLine(inf2);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            int idcar = int.Parse(Console.ReadLine());
                            Console.WriteLine("Add type to the car");
                            Console.ForegroundColor = ConsoleColor.White;
                            string types = await controllerCType.ShowTypes();
                            Console.WriteLine(types);
                            int idtype = int.Parse(Console.ReadLine());
                            string output = await controllerCar_Type.AddCarType(idcar, idtype);
                            if (output == "You added type to the car successfully")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(output);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(output);
                            }
                            Console.WriteLine(output);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 3:
                            Console.WriteLine("To add car type you must enter:");
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Seat Capacity: ");
                            int seatCapacity = int.Parse(Console.ReadLine());
                            Console.Write("Luxury Level: ");
                            string luxuryLevel = Console.ReadLine();
                            string infType = await controllerCType.AddType(name, seatCapacity, luxuryLevel);

                            if (infType == "The type is added successfully")
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(infType);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(infType);
                            }
                            
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 4:
                            Console.WriteLine("To add customer you must enter:");
                            Console.Write("First name: ");
                            string fname = Console.ReadLine();
                            Console.Write("Last name: ");
                            string lname = Console.ReadLine();
                            Console.Write("EGN: ");
                            string egn = Console.ReadLine();
                            Console.Write("Credit card number: ");
                            string card = Console.ReadLine();
                            Console.Write("Email: ");
                            string email = Console.ReadLine();
                            Console.Write("Phone: ");
                            string phone = Console.ReadLine();
                            Console.Write("City: ");
                            string city = Console.ReadLine();
                            Console.Write("Country: ");
                            string country = Console.ReadLine();
                            string infCs = await customer.AddCustomer(fname, lname, egn, card, email, phone, city, country);
                           Console.ForegroundColor= ConsoleColor.Green;
                            Console.WriteLine(infCs);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 5:
                            Console.WriteLine("To add office you must enter:");
                            Console.Write("Name: ");
                            string name1 = Console.ReadLine();
                            Console.Write("Address: ");
                            string address = Console.ReadLine();
                            Console.Write("City: ");
                            string city1 = Console.ReadLine();
                            Console.Write("Country: ");
                            string country1 = Console.ReadLine();
                            string infOf = await controllerOffice.AddOffice(name1, address, city1, country1);
                            if (infOf == "You successfully add office")
                            {

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(infOf);
                            }
                            else
                            {
                                Console.ForegroundColor= ConsoleColor.Red;
                            }
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 6:
                            Console.WriteLine("To add reservation you must enter:");
                            Console.Write("Start date: ");
                            DateTime start = DateTime.Parse(Console.ReadLine());
                            Console.Write("End date: ");
                            DateTime end = DateTime.Parse(Console.ReadLine());
                            Console.Write("Start Location: ");
                            string startLoc = Console.ReadLine();
                            Console.Write("End Location: ");
                            string endLoc = Console.ReadLine();
                            Console.Write("Start City: ");
                            string startCity = Console.ReadLine();
                            Console.Write("End City:");
                            string endCity = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.White;
                            string allcars = await controllerCar.ShowAllCarFromAllOfficesId();
                            Console.WriteLine(allcars);
                            Console.Write("\nChoose Car Id:");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            int carId = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.White;
                            string allCustomers = await customer.ALlCustomers();
                            Console.WriteLine(allCustomers);
                            Console.Write("\nChoose Customer Id: ");
                            int customerid = int.Parse(Console.ReadLine());
                            double price = await controllerCar.PricePerOneDayCarId(carId);
                            int days = CalculateDays(start, end);
                            double total = price * days;
                            Console.WriteLine($"It will cost {total}. Do you want to make the reservation? Y/N");
                            string yesNoRes;
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                yesNoRes = Console.ReadLine();
                                if (yesNoRes == "Y")
                                {
                                    
                                    string addRes = await reservation.AddReservation(start, end, startLoc, endLoc, startCity, endCity, carId, customerid);
                                    if (addRes == $"You successfully added reservation for {start} {end}")
                                    {


                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(addRes);
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(addRes);
                                    }
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                }
                                if (yesNoRes == "N")
                                {

                                }
                                if (yesNoRes != "Y" && yesNoRes != "N")
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Invalid operation");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                }
                            }
                            while (yesNoRes != "Y" && yesNoRes != "N");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid operation");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                    }
                }
                if (input == 2)
                {
                    Console.WriteLine("What do you want to remove:");
                    Console.WriteLine("1. Car");
                    Console.WriteLine("2. Type");
                    Console.WriteLine("3. Customer");
                    Console.WriteLine("4. Office");
                    Console.WriteLine("5. Reservation");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Which one do you want to remove?");
                            Console.ForegroundColor = ConsoleColor.White;
                            string car = await controllerCar.ShowAllCarFromAllOfficesId();
                            Console.WriteLine(car);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Choose: ");
                            int id = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.White;
                           
                            string removeCar = await controllerCar.RemoveCar(id);
                            if (removeCar == "There is no like this car")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(removeCar);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(removeCar);
                            }
                          
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 2:
                            Console.WriteLine("Which one do you want to remove:");
                            Console.ForegroundColor = ConsoleColor.White;
                            string type = await controllerCType.ShowTypes();
                            Console.WriteLine(type);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Choose: ");
                            int idt = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.White;
                            string removeType = await controllerCType.RemoveType(idt);
                            if (removeType == "There is no like this type")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(removeType);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(removeType);
                            }
                            
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 3:
                            Console.WriteLine("Which one do you want to remove:");
                            Console.ForegroundColor = ConsoleColor.White;
                            string customer1 = await customer.ShowEveryCustomer();
                            Console.WriteLine(customer1);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Choose: ");
                            int idC = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.White;
                            string removeCustomer = await customer.RemoveCustomer(idC);
                            if (removeCustomer == "There is no customer with this id")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(removeCustomer);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(removeCustomer);
                            }
                            
                            Console.WriteLine(removeCustomer);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 4:
                            Console.WriteLine("Which one do you want to remove:");
                            Console.ForegroundColor = ConsoleColor.White;
                            string office = await controllerOffice.ShowAllOffices();
                            Console.WriteLine(office);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Choose: ");
                            int idO = int.Parse(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.White;
                            string removeOffice = await controllerOffice.RemoveOffice(idO);
                            if (removeOffice == "There is no office with this id ")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(removeOffice);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(removeOffice);
                            }
                          
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 5:
                            Console.WriteLine("For which one customer do you want to remove the reservation:");
                            Console.ForegroundColor = ConsoleColor.White;
                            string customer2 = await customer.ShowEveryCustomer();
                            Console.WriteLine(customer2);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            int idCustomer = int.Parse(Console.ReadLine());
                            Console.WriteLine("His/Her reservations:");
                            Console.ForegroundColor = ConsoleColor.White;
                            string resCust = await reservation.ReservationsForCustomer(idCustomer);

                            if (resCust == "This customer don't have reservation/s")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(resCust);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                            }
                            else
                            {
                                List<int> officeIds = await reservation.LoadReservationsForCustomer(idCustomer);
                                List<int>loadIds=new List<int>();
                                foreach (var idof in officeIds)
                                {
                                    loadIds.Add(idof);
                                }
                                Console.WriteLine(resCust);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                int idRes = int.Parse(Console.ReadLine());
                                foreach (var idof in loadIds)
                                {
                                    if(idof == idRes)
                                    {
                                        string removeRes = await reservation.RemoveReservation(idRes);
                                        if (removeRes == "There is no reservation with this id")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(removeRes);
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine(removeRes);
                                        }
                                        
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("DONT TRY TO DELETE OTHERS RESERVATIONS!!!");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                    }
                                }
                               
                            }
                           
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid operation");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                    }
                }
                if (input == 3)
                {
                    Console.WriteLine("What do you want to change:");
                    Console.WriteLine("1. Car's office");
                    Console.WriteLine("2. Car's rating");
                    Console.WriteLine("3. Customer's phone");
                    Console.WriteLine("4. Customer's city");
                    Console.WriteLine("5. Customer's city and country");
                    Console.WriteLine("6. Office's address");
                    Console.WriteLine("7. Office's city");
                    Console.WriteLine("8. Office's city and country");
                    Console.WriteLine("9. Reservation' start date");
                    Console.WriteLine("10. Reservation' end date");
                    int option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Choose car to move:");
                            Console.ForegroundColor = ConsoleColor.White;
                            string car = await controllerCar.CarsOFfice();
                            Console.WriteLine(car);
                            int idCar = int.Parse(Console.ReadLine());
                            string inf = await controllerOffice.ShowAllOffices();
                            Console.WriteLine(inf);
                            int idOffice = int.Parse(Console.ReadLine());
                            string carBrandModel = await controllerCar.MoveCarOffice(idCar, idOffice);
                            if (carBrandModel == "This car is already in this office")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(carBrandModel);
                            }
                            if (carBrandModel == $"There is no office id like {idOffice}")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(carBrandModel);
                            }
                            else
                            {
                                Console.ForegroundColor= ConsoleColor.Green;
                                Console.WriteLine(carBrandModel);
                            }
                            
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 2:
                            Console.WriteLine("Choose car from these:");
                            Console.ForegroundColor = ConsoleColor.White;
                            string cars = await controllerCar.CarRating();
                            Console.WriteLine(cars);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("The number of the car:");
                            int carid = int.Parse(Console.ReadLine());
                            Console.Write("New Rating:");
                            double rating = double.Parse(Console.ReadLine());
                            string carUpdateRating = await controllerCar.CarUpdateRating(carid, rating);
                            if (carUpdateRating == "You cannot add rating greater than 10 or lower than 0!")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(carUpdateRating);
                            }
                            if (carUpdateRating == "The car already has this rating")
                            {
                                Console.ForegroundColor=ConsoleColor.Red;
                                Console.WriteLine(carUpdateRating);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(carUpdateRating);
                            }
                           
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 3:
                            Console.WriteLine("Choose customer:");
                            Console.ForegroundColor = ConsoleColor.White;
                            string customeri = await customer.CustomerPhone();
                            Console.WriteLine(customeri);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Customer id: ");
                            int cid = int.Parse(Console.ReadLine());
                            Console.Write("New Phone: ");
                            string phone = Console.ReadLine();
                            string newphone = await customer.CustomerNewPhone(cid, phone);
                            if (newphone == $"There is no customer with this id {cid}")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(newphone);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(newphone);
                            }
                            
                            
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 4:
                            Console.WriteLine("Choose customer:");
                            Console.ForegroundColor = ConsoleColor.White;
                            string customerCity = await customer.CustomerCityCountry();
                            Console.WriteLine(customerCity);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Customer id: ");
                            int cusid = int.Parse(Console.ReadLine());
                            Console.Write("New City: ");
                            string city = Console.ReadLine();
                            string newcity = await customer.CustomerNewCity(cusid, city);
                            if (newcity == $"There is no customer with this id {cusid}")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(newcity);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(newcity);
                            }
                           
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 5:
                            Console.WriteLine("Choose customer:");
                            Console.ForegroundColor = ConsoleColor.White;
                            string customerCity1 = await customer.CustomerCityCountry();
                            Console.WriteLine(customerCity1);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Customer id: ");
                            int custumerid = int.Parse(Console.ReadLine());
                            Console.Write("New City: ");
                            string city1 = Console.ReadLine();
                            Console.Write("New Country: ");
                            string country = Console.ReadLine();
                            string newcitycountry = await customer.CustomerNewCityCountry(custumerid, city1, country);

                            if (newcitycountry == $"There is no customer with this id {custumerid}")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(newcitycountry);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(newcitycountry);
                            }
                            Console.WriteLine(newcitycountry);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 6:
                            Console.WriteLine("Choose office");
                            Console.ForegroundColor = ConsoleColor.White;
                            string office = await controllerOffice.ShowAllOffices();
                            Console.WriteLine(office);
                            int officeid = int.Parse(Console.ReadLine());
                            Console.Write("New Address: ");
                            string address = Console.ReadLine();
                            string officeaddress = await controllerOffice.ChangeOfficeAddress(officeid, address);
                            if (officeaddress == "There is no office with this id")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(officeaddress);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(officeaddress);
                            }
                            
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 7:
                            Console.WriteLine("Choose office:");
                            Console.ForegroundColor = ConsoleColor.White;
                            string officeCity1 = await controllerOffice.ShowAllOfficesCityCountry();
                            Console.WriteLine(officeCity1);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Office id: ");
                            int officeid1 = int.Parse(Console.ReadLine());
                            Console.Write("New City: ");
                            string city2 = Console.ReadLine();

                            string newOfcity = await controllerOffice.ChangeOfficeCity(officeid1, city2);
                            if (newOfcity == "There is no office with this id")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(newOfcity);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(newOfcity);
                            }
                            
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 8:
                            Console.WriteLine("Choose office");
                            Console.ForegroundColor = ConsoleColor.White;
                            string officeCity2 = await controllerOffice.ShowAllOfficesCityCountry();
                            Console.WriteLine(officeCity2);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Office id: ");
                            int officeid2 = int.Parse(Console.ReadLine());
                            Console.Write("New City: ");
                            string city3 = Console.ReadLine();
                            Console.Write("New Country: ");
                            string country1 = Console.ReadLine();
                            string newcitycountry1 = await customer.CustomerNewCityCountry(officeid2, city3, country1);
                            if (newcitycountry1 == "There is no office with this id")
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(newcitycountry1);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(newcitycountry1);
                            }
                            
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 9:
                            Console.WriteLine("For which one customer do you want to change something about his reservation/s:");
                            Console.ForegroundColor = ConsoleColor.White;
                            string customer2 = await customer.ShowEveryCustomer();
                            Console.WriteLine(customer2);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Id of customer:");
                            int idCustomer = int.Parse(Console.ReadLine());
                            Console.WriteLine("His/Her reservations:");
                            Console.ForegroundColor = ConsoleColor.White;
                            string resCust = await reservation.ReservationsForCustomer(idCustomer);
                           
                            if (resCust == "This customer don't have reservation/s")
                            {
                                Console.ForegroundColor= ConsoleColor.Red;
                                Console.WriteLine(resCust);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                            }
                            else
                            {
                                List<int> officeIds = await reservation.LoadReservationsForCustomer(idCustomer);
                                List<int> loadIds = new List<int>();
                                foreach (var idof in officeIds)
                                {
                                    loadIds.Add(idof);
                                }
                                Console.WriteLine(resCust);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("Choose: ");
                                int idRes = int.Parse(Console.ReadLine());
                                
                                    if (loadIds.Contains(idRes))
                                    {
                                        Console.Write("New start date:");
                                        DateTime newstart = DateTime.Parse(Console.ReadLine());
                                        string start_date = await reservation.ChangeStartDate(idRes, newstart);
                                        if(start_date== "There is no reservation with this id")
                                        {
                                            Console.ForegroundColor=ConsoleColor.Red;
                                            Console.WriteLine(start_date);
                                        }
                                       if(start_date== "Start date cannot be the same as or later than the end date")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(start_date);
                                    }
                                    if (start_date == "You changed the start date successfully")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine(start_date);
                                    }
                                    else
                                    {
                                        Console.ForegroundColor= ConsoleColor.Red;
                                        Console.WriteLine(start_date);
                                    }
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("DONT TRY TO CHANGE OTHERS RESERVATIONS!!!");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                    }
                                

                            }
                           
                           
                            break;
                        case 10:
                            Console.WriteLine("For which one customer do you want to change something about his reservation/s:");
                            Console.ForegroundColor = ConsoleColor.White;
                            string customer3 = await customer.ShowEveryCustomer();
                            Console.WriteLine(customer3);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Id of customer:");
                            int idCustomer1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("His/Her reservations:");
                            Console.ForegroundColor = ConsoleColor.White;
                            string resCust1 = await reservation.ReservationsForCustomer(idCustomer1);
                           
                            if (resCust1 == "This customer don't have reservation/s")
                            {
                                Console.ForegroundColor= ConsoleColor.Red;
                                Console.WriteLine(resCust1);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                            }
                            else
                            {
                                List<int> officeIds = await reservation.LoadReservationsForCustomer(idCustomer1);
                                List<int> loadIds = new List<int>();
                                foreach (var idof in officeIds)
                                {
                                    loadIds.Add(idof);
                                }
                                Console.WriteLine(resCust1);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write("Choose: ");
                                int idRes = int.Parse(Console.ReadLine());
                                
                                    if (loadIds.Contains(idRes))
                                    {
                                        Console.Write("New end date:");
                                        DateTime newend = DateTime.Parse(Console.ReadLine());
                                        string end_date = await reservation.ChangeEndDate(idRes, newend);
                                    if(end_date== "There is no reservation with this id")
                                    {
                                        Console.ForegroundColor=ConsoleColor.Red;
                                        Console.WriteLine(end_date);
                                    }
                                    if (end_date == "End date cannot be the same as or earlier than the start date")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(end_date);
                                    }
                                    if(end_date== "You changed the end date successfully")
                                    {
                                        Console.ForegroundColor= ConsoleColor.Green;
                                        Console.WriteLine(end_date);
                                    }
                                    
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("DONT TRY TO CHANGE OTHERS RESERVATIONS!!!");
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                    }
                                

                            }
                            
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid operation");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                    }
                }

                if (input == 4)
                {
                    return;

                }
            }


            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
        }
    }
}