using Class02.AbstractionsAndInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.AbstractionsAndInterfaces.Interfaces
{
    public interface IWashVehicle
    {
        public void WashCar(Car car);

        public void WashTruck(Truck truck);
    }
}
