using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Interfaces
{
    public interface ILiveTraining
    {
        public ITrainer Trainer { get; set; }
        public DateTime DateAndTime { get; set; }
        public List<IPremiumUser> Users { get; set; }
    }
}
