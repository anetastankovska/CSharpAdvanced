using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class StandardUser : User, IStandardUser
    {
        public List<VideoTraining> VideoTrainings { get; set; }

        public StandardUser()
        {
            
        }
        public StandardUser(string firstname, string lastname, string username, string password)
            : base(firstname, lastname, username, password)
        {
            VideoTrainings = new List<VideoTraining>();
        }
        public StandardUser(string firstname, string lastname, string username, string password, List<VideoTraining> videoTrainings)
            : base(firstname, lastname, username, password)
        {
            VideoTrainings = videoTrainings;
        }
    }
}
