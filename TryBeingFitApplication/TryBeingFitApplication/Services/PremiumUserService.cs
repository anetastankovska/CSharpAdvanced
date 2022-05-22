using Interfaces;
using Interfaces.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PremiumUserService 
    {
        public IPremiumUser CurrentUser { get; set; }
        public List<IPremiumUser> PremiumUsers { get; set; }

        public string ShowLiveTrainings(List<ILiveTraining> liveTrainigs)
        {
            if(liveTrainigs == default)
            {
                return "There are no available trainings at the moment";
            }
            return string.Join("\n", liveTrainigs);
        }

        public string GetAccount()
        {
            try
            {
                int len = CurrentUser.Password.Length;
                string account = $"FirstName: {CurrentUser.FirstName}\n lastname: {CurrentUser.LastName}\n {CurrentUser.Username}\n {CurrentUser.Password.Select(x => "*")}";
                return account;
            }
            catch (ArgumentNullException)
            {
                return "User does not exist";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ChooseLiveTraining(List<ILiveTraining> liveTrainings, int choice) 
        {
            if (CurrentUser.CompletedLiveTraining)
            {
                return "You have already completed your Live Training";
            }
            ILiveTraining chosen = liveTrainings[choice - 1];
            CurrentUser.CompletedLiveTraining = true;
            return $"You have successfully scheduled your training: \n{chosen}";
        }
    }
}
