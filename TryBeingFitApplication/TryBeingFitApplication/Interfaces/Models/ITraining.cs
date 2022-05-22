using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Models
{
    public interface ITraining
    {
        public string Title { get; set; }
        public ITrainer Trainer { get; set; }
    }
}
