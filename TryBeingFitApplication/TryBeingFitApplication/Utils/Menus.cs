using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class Menus
    {
        public static int WelcomeMenu()
        {
            Console.WriteLine("***** TRY BEING FIT ***** \n\nWelcome to our app. Select an option below: \n1. Login \n2. Register \n3.Exit");
            return Validations.ValidateInput(1, 3);
        }
        public static int PickRoleMenu()
        {
            Console.WriteLine("***** TRY BEING FIT ***** \n\nWelcome to our app. Please pick your role below.\n1. Standard User \n2. Premium user \n3. Trainer \n4. Exit");
            return Validations.ValidateInput(1, 4);
        }

        public static int StandardUserMenu()
        {
            Console.WriteLine("Pick an option below: \n1. Train \n2. Upgrade to premium \n3. Account \n4. Log out");
            return Validations.ValidateInput(1, 4);
        }

        public static int PremiumUserMenu()
        {
            Console.WriteLine("Pick an option below: \n1. Train \n2. Account \n4. Log out");
            return Validations.ValidateInput(1, 3);
        }

        public static int TrainerMenu()
        {
            Console.WriteLine("Pick an option below: \n1. Reschedule training \n2. Account \n3. Train \n4. Log out");
            return Validations.ValidateInput(1, 4);
        }

        public static int SelectTrainingType()
        {
            Console.WriteLine("Please select the type of the training below: \n1. Video training \n2. Live training");
            return Validations.ValidateInput(1, 2);
        }
    }
}
