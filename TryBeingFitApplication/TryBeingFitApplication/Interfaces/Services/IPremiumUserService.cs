using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IPremiumUserService
    {
        public IPremiumUser PremiumUser { get; set; }
        public List<IPremiumUser> PremiumUsers { get; set; }

        public string ShowLiveTrainings(List<ILiveTraining> liveTrainigs);

        public string ChooseLiveTraining();

        public string GetAccount();

    }
}
