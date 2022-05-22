using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    public interface ILiveTraining : ITraining
    {
        public ITrainer Trainer { get; set; }
        public DateTime DateAndTime { get; set; }
    }
}
