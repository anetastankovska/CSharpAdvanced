// See https://aka.ms/new-console-template for more information
using Class02.AbstractionsAndInterfaces.Models;
using Class02.AbstractionsAndInterfaces.Service;

Console.WriteLine("Hello, World!");

VehicleWarehouse.InitializeData();  // Load cars
Vehicle  v = VehicleWarehouse.BrowseVehicle();  // Asks to select a vehicle
Console.WriteLine(VehicleWarehouse.ShowVehicleStatus(v));   // Prints status for the selected vehicle
CarCenter carCenter = new CarCenter();

int selectedOption = VehicleWarehouse.ShowServices();
carCenter.DoService(v, selectedOption);




