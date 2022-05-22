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
        public IUser Login<T>(string username, string password)
        {
            IUser temp = null;
            switch (typeof(T))
            {
                case IStandardUser:
                    break;
                case IPremiumUser:
                    break;
                case ITrainer:
                    break;
                default:
                    break;
            }
            return temp;
        }

        public void Train<T>(T user)
        {

        }

        public void LogOut(IUser currentUser)
        {
            currentUser = null;
        }
        public void Exit<T>(T user)
        {

        }

        public void Train<T>()
        {
            throw new NotImplementedException();
        }

        public void Exit<T>()
        {
            throw new NotImplementedException();
        }
    }
}
