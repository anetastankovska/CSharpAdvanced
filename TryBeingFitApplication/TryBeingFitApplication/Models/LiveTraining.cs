using Interfaces;
using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class LiveTraining : Training, ILiveTraining
    {
        public DateTime DateAndTime { get; set; }

        public LiveTraining(string title, ITrainer trainer, DateTime dateTime)
            : base (title, trainer)
        {
            DateAndTime = dateTime;
        }

        public override string ToString()
        {
            return $"Title: {Title}. Trainer {Trainer}. Date and time {DateAndTime.ToShortDateString}";
        }
    }
}
