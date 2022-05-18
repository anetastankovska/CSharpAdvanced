using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VideoTraining : Training, IVideoTraining
    {
        public float Rating { get; set; }

        public VideoTraining(string title, ITrainer trainer, float rating)
            : base (title, trainer)
        {
            Rating = rating;
        }

        public override string ToString()
        {
            return $"Title: {Title}. Trainer: {Trainer}.";
        }
    }
}
