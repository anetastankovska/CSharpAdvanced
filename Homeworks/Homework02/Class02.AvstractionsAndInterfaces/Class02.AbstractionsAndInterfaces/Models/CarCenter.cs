using Class02.AbstractionsAndInterfaces.Interfaces;
using Class02.AbstractionsAndInterfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.AbstractionsAndInterfaces.Models
{
    public class CarCenter : IWashVehicle, IRepairService, IGasPump
    {
        public IWashVehicle WashService { get; set; } = new CarWash();
        public IRepairService RepairService { get; set; } = new RepairService();
        public IGasPump GasStation { get; set; } = new GasPump();

        public bool CheckVehicle(Vehicle vehicle)
        {
            return RepairService.CheckVehicle(vehicle);
        }

        public void FixVehicle(Vehicle vehicle)
        {
            RepairService.FixVehicle(vehicle);
        }

        public void RefillGas(Vehicle vehicle)
        {
            GasStation.RefillGas(vehicle);
        }

        public void WashVehicle(Vehicle vehicle)
        {
            if (vehicle.GetType() == typeof(Car))
            {
                Car car = (Car)vehicle;
                WashCar(car);
            }
            else if (vehicle.GetType() == typeof(Truck))
            {
                Truck truck = (Truck)vehicle;
                WashTruck(truck);
            }
            else
            {
                Console.WriteLine("The given object is not a vehicle.");
            }
        }

        public void WashCar(Car car)
        {
            WashService.WashCar(car);
        }

        public void WashTruck(Truck truck)
        {
            WashService.WashTruck(truck);
        }

        public void DoService(Vehicle vehicle, int selection)
        {
            switch (selection)
            {
                case 1:
                    WashVehicle(vehicle);
                    break;
                case 2:
                    CheckVehicle(vehicle);
                    break;
                case 3:
                    FixVehicle(vehicle);
                    break;
                case 4:
                    RefillGas(vehicle);
                    break;

                default:
                    break;
            }
        }
    }
}
