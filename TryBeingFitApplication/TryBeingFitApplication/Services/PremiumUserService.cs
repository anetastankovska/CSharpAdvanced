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
    public class PremiumUserService 
    {
        public List<IPremiumUser> PremiumUsers { get; set; }

        public string ShowLiveTrainings(List<ILiveTraining> liveTrainigs)
        {
            if(liveTrainigs == default)
            {
                return "There are no available trainings at the moment";
            }
            return string.Join("\n", liveTrainigs);
        }
    }
}
