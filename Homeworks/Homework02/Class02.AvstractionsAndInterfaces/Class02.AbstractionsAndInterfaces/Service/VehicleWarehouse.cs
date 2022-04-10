using Class02.AbstractionsAndInterfaces.Enums;
using Class02.AbstractionsAndInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.AbstractionsAndInterfaces.Service
{
    public static class VehicleWarehouse
    {
        public static List<Car> Cars { get; set; }
        public static List<Truck> Trucks { get; set; }

        public static void InitializeData()
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();

            Cars.Add(new Car("BMW", "X5", 1234, Fuel.Diesel, false, false, false));
            Cars.Add(new Car("Audi", "Q5", 4523, Fuel.Petrol, true, true, false));
            Cars.Add(new Car("Tesla", "X Plaid", 9076, Fuel.Electricity, false, false, false));
            Cars.Add(new Car("Toyota", "CH-R", 5632, Fuel.Electricity, true, true, true));
            Cars.Add(new Car("Fiat", "500", 0875, Fuel.Petrol, false, true, false));
            Cars.Add(new Car("Wolkswagen", "Passat", 2598, Fuel.Diesel, false, true, true));
            Cars.Add(new Car("Zastava", "101", 5432, Fuel.LPG|Fuel.Petrol, false, true, false));
            Cars.Add(new Car("Opel","Insignia", 6743, Fuel.LPG|Fuel.Petrol, true, true, false));
            Cars.Add(new Car("Mercedez", "GLA", 6521, Fuel.Electricity, true, false, false));
            Trucks.Add(new Truck("Volvo", "VNX", 098564, Fuel.Petrol, false, true, false));
            Trucks.Add(new Truck("Scania", "R500", 621893, Fuel.Diesel, false, true, true));
            Trucks.Add(new Truck("Isuzu", "NPR", 019865, Fuel.LPG, true, true, true));
            Trucks.Add(new Truck("MAN", "Conrad", 793451, Fuel.Petrol, false, true, true));
            Trucks.Add(new Truck("TAMce", "80 T5", 653219, Fuel.Diesel, false, true, false));

        }

        public static int ShowServices()
        {
           
            Console.WriteLine("\nSelect an option: \n1. Wash vehicle \n2. Check vehicle \n3. Repair vehicle \n4. Refill tank");
            return ValidateInput(1, 4);
        }

        private static int ValidateInput(int min, int max)
        {
            string input = Console.ReadLine();
            bool isValid = int.TryParse(input, out int validInput);
            while(validInput < min || validInput > max)
            {
                Console.WriteLine("Please select a valid option");
                input = Console.ReadLine();
            }
            return validInput;
            
        }
        public static Vehicle BrowseVehicle()
        {
            int cnt = 1;
            foreach (Car car in Cars)
            {
                Console.WriteLine($"{cnt++}.\t({car.GetType().ToString().Split(".").Last()})\t{car}");
            }
            foreach (Truck truck in Trucks)
            {
                Console.WriteLine($"{cnt++}.\t({truck.GetType().ToString().Split(".").Last()})\t{truck}"); ;
            }

            Console.WriteLine("\nSelect vehicle:");
            int index = ValidateInput(1, cnt);
            if(index > Cars.Count)
            {
                return Trucks[index - Cars.Count - 1];
            }
            return Cars[index - 1];
        }
        
        public static string BoolToYesNo(bool b)
        {
            return b ? "yes" : "no";
        }

        public static string ShowVehicleStatus(Vehicle vehicle)
        {
            return $"\n{vehicle.Brand} {vehicle.Model}: \nis clean: {BoolToYesNo(vehicle.IsClean)} \nneeds repairment: {BoolToYesNo(vehicle.IsBroken)} \ngas tank full: {BoolToYesNo(vehicle.IsGasFull)}";
        }
    }
}
