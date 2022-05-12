using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class PremiumUser : User, IPremiumUser
    {
        public List<VideoTraining> VideoTrainings { get; set; }
        public LiveTraining LiveTraining { get; set; }

        public PremiumUser()
        {

        }
        public PremiumUser(string firstname, string lastname, string username, string password)
            : base(firstname, lastname, username, password)
        {
            VideoTrainings = new List<VideoTraining>();
        }
        public PremiumUser(string firstname, string lastname, string username, string password, List<VideoTraining> videoTrainings, LiveTraining liveTraining)
            : base(firstname, lastname, username, password)
        {
            VideoTrainings = videoTrainings;
            LiveTraining = liveTraining;
        }
        public PremiumUser(string firstname, string lastname, string username, string password, LiveTraining liveTraining)
            : base(firstname, lastname, username, password)
        {
            VideoTrainings = new List<VideoTraining>();
            LiveTraining = liveTraining;
        }
    }
}
