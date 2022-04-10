// See https://aka.ms/new-console-template for more information
using Class02.AbstractionsAndInterfaces.Models;
using Class02.AbstractionsAndInterfaces.Service;

VehicleWarehouse.InitializeData();  // Load cars
CarCenter carCenter = new CarCenter();
while (true)
{
    Console.Clear();
    Vehicle v = VehicleWarehouse.BrowseVehicle();  // Asks to select a vehicle
    Console.WriteLine(VehicleWarehouse.ShowVehicleStatus(v));   // Prints status for the selected vehicle

    int selectedOption = VehicleWarehouse.ShowServices();
    carCenter.DoService(v, selectedOption);
    Console.WriteLine(VehicleWarehouse.ShowVehicleStatus(v));
    Console.WriteLine("Press ctrl + c to exit");
    Thread.Sleep(5000);
}






