using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    public interface ITrainerService
    {
        public void RescheduleTraining(ILiveTraining liveTraining, DateTime newdateTime);
        public void RescheduleTraining(ILiveTraining liveTraining, string newdateTime)
    }
}
