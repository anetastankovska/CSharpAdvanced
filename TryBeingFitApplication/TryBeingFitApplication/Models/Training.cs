using Interfaces;
using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Training
    {
        public string Title { get; set; }
        public ITrainer Trainer { get; set; }

        public Training(string title, ITrainer trainer)
        {
            Title = title;
            Trainer = trainer;
        }
    }
}
