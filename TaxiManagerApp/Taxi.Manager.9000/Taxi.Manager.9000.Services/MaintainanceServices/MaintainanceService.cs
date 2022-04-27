using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Models.Enums;
using Taxi.Manager._9000.Models.Models;
using Taxi.Manager._9000.Services.Helpers;

namespace Taxi.Manager._9000.Services.MaintainanceServices
{
    internal class MaintainanceService
    {
        List<Car> Cars { get; set; }

        Helper helpers = new Helper();

        public void ListAllVehicles()
        {
            List<string> listedVehicles = Cars
                                          .Select(x =>
                                          {
                                              return $"{x.Id}) {x.Model} with {x.LicensePlate} and utilized             {helpers.CheckUtilized(Cars, (x.Model))}%";
                                          }).ToList();

            listedVehicles.ForEach(x => Console.WriteLine(x));
        }

        public Dictionary<Car, LicensePlateStatus> LicensePlatesStatus()
        {
            Dictionary<Car, LicensePlateStatus> status = new Dictionary<Car, LicensePlateStatus>();
            foreach (Car car in Cars)
            {
                TimeSpan timespan = DateTime.Now - car.ExpiryDate;
                double totalHours = timespan.TotalHours;
                if (totalHours > 0)
                {
                    status.Add(car, LicensePlateStatus.Expired);
                }
                else
                {
                    if (Math.Abs(totalHours) < 24 * 30.5 * 3)
                    {
                        status.Add(car, LicensePlateStatus.NearExpiry);
                    }
                    else
                    {
                        status.Add(car, LicensePlateStatus.Valid);
                    }
                }
            }
            return status;
        }

    }
}
