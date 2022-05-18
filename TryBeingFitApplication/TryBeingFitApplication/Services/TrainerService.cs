using Interfaces;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TrainerService : ITrainerService
    {
        public void RescheduleTraining(ILiveTraining liveTraining, DateTime newdateTime)
        {
            try
            {
                liveTraining.DateAndTime = newdateTime;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void RescheduleTraining(ILiveTraining liveTraining, string newdateTime)
        {
            try
            {
                liveTraining.DateAndTime = DateTime.Parse(newdateTime);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
