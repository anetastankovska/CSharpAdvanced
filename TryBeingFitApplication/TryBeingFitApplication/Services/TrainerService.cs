using Interfaces;
using Interfaces.Models;
using Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TrainerService : ITrainerService
    {
        public ITrainer CurrentUser { get; set; }
        public List<ITrainer> Trainers { get; set; }
        public string RescheduleTraining(ITrainer trainer, string newdateTime)
        {
            string message = string.Empty;
            try
            {
                DateTime newDateTime = DateTime.Parse(newdateTime);
                if(newDateTime.DayOfYear < DateTime.Now.DayOfYear)
                {
                    message = "The date you are trying to enter is earlier than today";
                }
                else if(newDateTime.DayOfYear > DateTime.Now.DayOfYear)
                {
                    trainer.LiveTraining.DateAndTime = DateTime.Parse(newdateTime);
                    message = $"Your training has been successfully rescheduled. \nThe new date and time are: {DateTime.Now.ToShortDateString}";
                }
                else if (newDateTime.DayOfYear == DateTime.Now.DayOfYear)
                {
                    message = "The entered date is too close to reschedule it. We are very sorry to inform you that it would not be possible at this time.";
                }  
            }
            catch (Exception ex)
            {
                return "An error has occured while trying to reschedule the training. Please check the dates again";
            }
            return message;
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

        public string Train(ITrainer trainer)
        {
            string result = string.Empty;
            try
            {
                int days = trainer.LiveTraining.DateAndTime.DayOfYear - DateTime.Now.DayOfYear;

                if (days > 0)
                {
                    result = $"It is too early to train. you have {days} left until your training.";
                }
                else if (days < 0)
                {
                    result = $"You have already done your training. Please check your schedule.";
                }
                else if (days == 0)
                {
                    result = $"Your training is today. Prepare well for it!";
                }
            }
            catch (Exception)
            {
                return "Something wrong happened, please check with your supervisor.";
            }
            return result;
        }
    }
}
