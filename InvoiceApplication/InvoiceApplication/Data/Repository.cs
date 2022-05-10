using Models.Classes;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class Repository
    {
        public static List<IUser> Users { get; set; } = new List<IUser>();
        public static List<IAdmin> Admins { get; set; } = new List<IAdmin>();
        public static List<ICompany> Companies { get; set; } = new List<ICompany>();

        public static void Init()
        {
            Users.Add(new User("Vlatko", "Tasevski", "vlatko1", "pass1", 30000));
            Users.Add(new User("Stefan", "Ivanovski", "stefan2", "pass2", 25000));
            Users.Add(new User("Aleksadar", "Zhivkovic", "aleksandar3", "pass3", 40000));
            Users.Add(new User("Marija", "Kolevska", "marija4", "pass4", 20000));
            Users.Add(new User("Kristijan", "Karanfilovski", "kristijan5", "pass5", 20000));


            Companies.Add(new Company("EVN"));
            Companies[0].IssueInvoice(Users[0] ,new Invoice(1500, DateTime.Now.AddDays(-20), DateTime.Now.AddDays(+5), "unpaid"));
            Companies[0].IssueInvoice(Users[1], new Invoice(Users[1], 2500, DateTime.Now.AddDays(-45), DateTime.Now.AddDays(-10), "paid"));
            Companies[0].IssueInvoice(Users[2], new Invoice(Users[2], 900, DateTime.Now.AddDays(-20), DateTime.Now.AddDays(+10), "paid"));
            Companies[0].IssueInvoice(Users[3], new Invoice(3000, DateTime.Now.AddDays(-40), DateTime.Now.AddDays(-25), "paid"));

            Companies.Add(new Company("BEG"));
            Companies[1].IssueInvoice(Users[0], new Invoice(850, DateTime.Now.AddDays(-25), DateTime.Now.AddDays(-5), "unpaid"));
            Companies[1].IssueInvoice(Users[1], new Invoice(1350, DateTime.Now.AddDays(-10), DateTime.Now.AddDays(+15), "unpaid"));
            Companies[1].IssueInvoice(Users[2], new Invoice(750, DateTime.Now.AddDays(-35), DateTime.Now.AddDays(-10), "paid"));
            Companies[1].IssueInvoice(Users[3], new Invoice(3000, DateTime.Now.AddDays(-15), DateTime.Now.AddDays(+5), "unpaid"));

            Companies.Add(new Company("Vododod"));
            Companies[2].IssueInvoice(Users[0], new Invoice(320, DateTime.Now.AddDays(-13), DateTime.Now.AddDays(+2), "paid"));
            Companies[2].IssueInvoice(Users[1], new Invoice(470, DateTime.Now.AddDays(-22), DateTime.Now.AddDays(-3), "unpaid"));
            Companies[2].IssueInvoice(Users[2], new Invoice(290, DateTime.Now.AddDays(-18), DateTime.Now.AddDays(+8), "unpaid"));
            Companies[2].IssueInvoice(Users[3], new Invoice(730, DateTime.Now.AddDays(-15), DateTime.Now.AddDays(+10
                ), "paid"));

            Admins.Add(new Admin("Aneta", "Stankovska", "aneta6", "pass6", Companies[0]));
            Admins.Add(new Admin("Ilija", "Mitev", "ilija7", "pass7", Companies[1]));
            Admins.Add(new Admin("Igor", "Nikoloski", "igor8", "pass8", Companies[2]));

            Companies[0].AssignAdmin(Admins[0]);
            Companies[1].AssignAdmin(Admins[1]);
            Companies[2].AssignAdmin(Admins[2]);
        }
    }
}
