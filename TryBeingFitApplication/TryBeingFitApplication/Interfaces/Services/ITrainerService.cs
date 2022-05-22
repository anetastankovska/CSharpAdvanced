using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    public interface ITrainerService
    {
        public ITrainer CurrentUser { get; set; }
        public List<ITrainer> Trainers { get; set; }

        public string RescheduleTraining(ITrainer trainer, string newdateTime);
        public string Train(ITrainer trainer);
        public string GetAccount();
    }
}
