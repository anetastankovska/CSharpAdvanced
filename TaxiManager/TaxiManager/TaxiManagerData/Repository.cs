using Models.Classes;
using Models.Enums;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Repository
    {
        public static List<ICar> Cars { get; set; } = new List<ICar>();
        public static List<IDriver> Drivers { get; set; } = new List<IDriver>();
        public static List<IUser> Users { get; set; } = new List<IUser>();

        
        static Repository()
        {
            Users.Add(new User(1, "admin01", "pass01", Role.Administrator));
            Users.Add(new User(2, "admin02", "pass02", Role.Administrator));
            Users.Add(new User(3, "admin03", "pass03", Role.Administrator));
            Users.Add(new User(4, "manager04", "pass04", Role.Manager));
            Users.Add(new User(5, "manager05", "pass05", Role.Manager));
            Users.Add(new User(6, "manager06", "pass06", Role.Manager));
            Users.Add(new User(7, "maintain07", "pass07", Role.Maintainance));
            Users.Add(new User(8, "maintain08", "pass08", Role.Maintainance));
            Users.Add(new User(7, "maintain09", "pass09", Role.Maintainance));

            Car toyota = new Car(1, "Toyota", "SK1234AB", DateTime.Parse("2022/04/30"));
            Car mercedez = new Car(2, "Mercedez", "SK2345AB", DateTime.Parse("2023/01/10"));
            Car volvo = new Car(3, "Volvo", "SK43456AB", DateTime.Parse("2022/12/20"));
            Car skoda = new Car(4, "Skoda", "SK0987AB", DateTime.Parse("2022/12/20"));
            Car renault = new Car(4, "Renault", "SK5901AB", DateTime.Parse("2023/7/15"));

            Cars.Add(toyota);
            Cars.Add(mercedez);
            Cars.Add(volvo);
            Cars.Add(skoda);
            Cars.Add(renault);

            Drivers.Add(new Driver(1, "Aneta", "Stankovska", Shift.None, volvo, "12345", new DateTime(2023, 9, 1)));
            Drivers.Add(new Driver(2, "Stefan", "Ivanovski", Shift.Evening, toyota, "42876", new DateTime(2025, 10, 15)));
            Drivers.Add(new Driver(3, "Aleksandar", "Zivkovic", Shift.Afternoon, mercedez, "78123", new DateTime(2025, 9, 1)));
            Drivers.Add(new Driver(4, "Bob", "Bobsky", Shift.None, skoda, "98564", new DateTime(2023, 4, 10)));
            Drivers.Add(new Driver(5, "Ilija", "Mitev", Shift.Morning, volvo, "23415", new DateTime(2023, 4, 10)));
            Drivers.Add(new Driver(5, "Marija", "Kolevska", Shift.Afternoon, renault, "23415", new DateTime(2023, 4, 10)));
            Drivers.Add(new Driver(5, "Kristijan", "Karanfilovski", Shift.None, toyota, "23415", new DateTime(2023, 1, 1)));
            Drivers.Add(new Driver(5, "Maja", "Nikolic", Shift.Morning, mercedez, "23415", new DateTime(2022, 5, 15)));
        }
    }
}

