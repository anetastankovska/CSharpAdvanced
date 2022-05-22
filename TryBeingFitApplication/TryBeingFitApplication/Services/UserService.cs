using Interfaces;
using Interfaces.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService : IUserService
    {
        public IUser CurrentUser { get; set; }  
        List<IStandardUser> StandardUsers { get; set; } = new List<IStandardUser>();
        List<IPremiumUser> PremiumUsers { get; set; } = new List<IPremiumUser>();
        List<ITrainer> Trainers { get; set; } = new List<ITrainer>();
        public IUser Login<T>(string username, string password)
        {
            IUser temp = null;
            switch (typeof(T))
            {
                case IStandardUser:
                    temp = StandardUsers.FirstOrDefault(x => x.Username == username && x.Password == password);
                    break;
                case IPremiumUser:
                    temp = PremiumUsers.FirstOrDefault(x => x.Username == username && x.Password == password);
                    break;
                case ITrainer:
                    temp = Trainers.FirstOrDefault(x => x.Username == username && x.Password == password);
                    break;
                default:
                    throw new Exception("The credentiala are not valid. Try again");
            }
            return temp;
        }

        public void Logout()
        {
            CurrentUser = null;
        }
        public void Exit()
        {
            throw new ApplicationException();
        }
    }
}
