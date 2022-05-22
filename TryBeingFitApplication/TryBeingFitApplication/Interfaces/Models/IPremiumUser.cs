using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    public interface IPremiumUser : IUser
    {
        public bool CompletedLiveTraining { get; set; }
    }
}
