using Data;
using Models.Classes;
using Models.Enums;
using Models.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Services
{
    public class MaintainanceService : IMaintainanceService
    {
        public List<ICar> Cars { get; set; } = Repository.Cars;

        Helpers helpers = new Helpers();
        public string ListAllCars()
        {
            return string.Join("\n", Cars.Select(x => $"{Cars.IndexOf(x) + 1}. {x} {x.CheckUtilized()}%"));
        }

        public Dictionary<Car, LicensePlateStatus> LicensePlatesStatus()
        {
            Dictionary<Car, LicensePlateStatus> status = new Dictionary<Car, LicensePlateStatus>();
            Cars.ForEach(x => status.Add((Car)x, x.CarLicenseStatus()));
            return status;
        }

        public string ShowTaxiLicenseStatus()
        {
            List<string> result = new List<string> { "---- Taxi license statuses ----\n" };
            Dictionary<Car, LicensePlateStatus> statuses = LicensePlatesStatus();
            int cnt = 1;
            foreach (var car in statuses)
            {
                ConsoleColor clr = car.Value == LicensePlateStatus.Expired ? ConsoleColor.Red : car.Value == LicensePlateStatus.NearExpiry ? ConsoleColor.Yellow : ConsoleColor.Green;
                result.Add($"{cnt++}. {car.Key.Id} {car.Key.Model}: {helpers.ColoredString(car.Value.ToString(), clr)}");
            }
            return string.Join("\n", result);
        }
    }
}
