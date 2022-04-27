using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Models.Enums;

namespace Taxi.Manager._9000.Models.Interfaces
{
    public interface ICar
    {
        public bool IsCarAvailable(Shift shift);
        public LicensePlateStatus CarLicenseStatus();
    }
}
