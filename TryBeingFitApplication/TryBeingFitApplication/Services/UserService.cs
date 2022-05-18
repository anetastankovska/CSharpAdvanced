using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UserService
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

    }
}
