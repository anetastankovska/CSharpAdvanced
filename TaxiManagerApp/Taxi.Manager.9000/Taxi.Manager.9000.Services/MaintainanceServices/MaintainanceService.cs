using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Models.Enums;
using Taxi.Manager._9000.Models.Models;
using Taxi.Manager._9000.Services.Helpers;
using Taxi.Manager._9000.Services.Interfaces;

namespace Taxi.Manager._9000.Services.MaintainanceServices
{
    public class MaintainanceService : IMaintainanceService
    {
        public List<Car> Cars { get; set; }

        Helper helpers = new Helper();

        public string ListAllVehicles()
        {
            List<string> listedVehicles = Cars
                                          .Select(x =>
                                          {
                                              return $"{x.Id}) {x.Model} with {x.LicensePlate} and utilized             {helpers.CheckUtilized(Cars, (x.Model))}%";
                                          }).ToList();

            return String.Join("\n", listedVehicles);
        }

        public Dictionary<Car, LicensePlateStatus> LicensePlatesStatus()
        {
            Dictionary<Car, LicensePlateStatus> status = new Dictionary<Car, LicensePlateStatus>();
            Cars.ForEach(x=> status.Add(x, x.CarLicenseStatus()));
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
