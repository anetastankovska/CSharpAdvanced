using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi.Manager._9000.Models.Models;
using Taxi.Manager._9000.Models.Enums;

namespace Taxi.Manager._9000.Data
{
    public static class Repository
    {
        public static List<Car> Cars { get; set; } = new List<Car>();
        public static List<Driver> Drivers { get; set; } = new List<Driver>();
        public static List<User> Users { get; set; } = new List<User>();
        

        static Repository()
        {
            Users.Add(new User(01, "admin01", "pass01", Role.Administrator));
            Users.Add(new User(02, "admin02", "pass02", Role.Administrator));
            Users.Add(new User(03, "admin03", "pass03", Role.Administrator));
            Users.Add(new User(04, "manager04", "pass04", Role.Manager));
            Users.Add(new User(05, "manager05", "pass05", Role.Manager));
            Users.Add(new User(06, "manager06", "pass06", Role.Manager));
            Users.Add(new User(07, "maintainance07", "pass07", Role.Maintainance));
            Users.Add(new User(08, "maintainance08", "pass08", Role.Maintainance));
            Users.Add(new User(07, "maintainance09", "pass09", Role.Maintainance));

            Car toyota = new Car(1, "Toyota", "SK1234AB", DateTime.Parse("2022/04/30"));
            Car mercedez = new Car(2, "Mercedez", "SK2345AB", DateTime.Parse("2023/01/10"));
            Car volvo = new Car(3, "Volvo", "SK43456AB", DateTime.Parse("2022/12/20"));
            Car skoda = new Car(4, "Skoda", "SK0987AB", DateTime.Parse("2022/12/20"));

            Cars.Add(toyota);
            Cars.Add(mercedez);
            Cars.Add(volvo);
            Cars.Add(skoda);

            Drivers.Add(new Driver(1, "Aneta", "Stankovska", Shift.Morning, volvo, "12345", new DateTime(2023,9,1)));
            Drivers.Add(new Driver(2, "Stefan", "Ivanovski", Shift.Evening, toyota, "12345", new DateTime(2025, 10, 15)));
            Drivers.Add(new Driver(3, "Aleksandar", "Zivkovic", Shift.Afternoon, mercedez, "12345", new DateTime(2025, 9,1)));
            Drivers.Add(new Driver(4, "Bob", "Bobsky", Shift.Morning, skoda, "12345", new DateTime(2023, 4, 10)));

            
        }
    }
}
