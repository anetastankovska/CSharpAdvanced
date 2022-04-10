using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02.AbstractionsAndInterfaces.Enums
{
    [Flags]
    public enum Fuel
    {
        Petrol = 1, 
        Diesel = 2, 
        LPG = 4,
        Electricity = 8
    }
}
