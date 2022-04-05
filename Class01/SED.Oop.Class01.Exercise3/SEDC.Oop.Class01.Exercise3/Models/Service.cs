﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Oop.Class01.Exercise3.Models
{
    public class Service
    {
        public static void Main (params string[] args)
        {
            int mainMenuSelection = MainMenu();
            switch (mainMenuSelection)
            {
                case 1:
                    Game();
                    break;
                case 2:
                    Stats();
                    break;
                case 3:
                    Exit();
                    break;
                default:
                    break;
            }
        }

        public static int MainMenu()
        {
            Console.WriteLine("Please select option: \n1. New Game \n2. Stats \n3. Exit");
            int selection = ValidateInput(1, 3);
            return selection;
        }

        public static void Stats()
        {

        }

        public static void Exit()
        {
            return;
        }

        public static int UserChoice()
        {
            int validInt = ValidateInput(1, 3);
            return validInt;

        }
        //public static int SelectRandomNum1()
        //{
        //    Random rnd = new Random();
        //    int selected = rnd.Next(1, 3);
        //    return selected;
        //}

        public static int SelectRandomNum()
        {
            Random rnd = new Random();
            int selected = rnd.Next(0, 300);
            selected = selected < 100 ? 1 : selected < 200 ? 2 : 3;
            return selected;
        }

        public static int ValidateInput(int min, int max)
        {
            int result;
            string input = Console.ReadLine();
            while (int.TryParse(input, out result) && result < min || result > max)
            {
                Console.WriteLine("Please enter a valid input.");
                input = Console.ReadLine();
            }
            return result;

        }
        public static void ShowPicks(int userNum, int computerNum)
        {
            
            switch (userNum)
            {
                case 1:
                    Console.WriteLine("The user selection is Rock");
                    break;
                case 2:
                    Console.WriteLine("The user selection is Paper");
                    break;
                case 3:
                    Console.WriteLine("The user selection is Scissors");
                    break;
                default:
                    break;
            }

            switch (computerNum)
            {
                case 1:
                    Console.WriteLine("The computer selection is Rock");
                    break;
                case 2:
                    Console.WriteLine("The computer selection is Paper");
                    break;
                case 3:
                    Console.WriteLine("The computer selection is Scissors");
                    break;
                default:
                    break;
            }
        }

        public static int Round()
        {
            Console.WriteLine("Please select which role you want to play: \n1. Rock \n2. Paper \n3. Scissors");
            int user = UserChoice();
            int pc = SelectRandomNum();
            ShowPicks(user, pc);
            int winner = 0;

            if(user == 1 && pc == 1)
            {
                Console.WriteLine("User: rock, computer: rock.");
                Console.WriteLine("Noone wins");
            }
            else if(user == 2 && pc == 2)
            {
                Console.WriteLine("User: paper, computer: paper.");
                Console.WriteLine("Noone wins");
            }
            else if( user == 3 && pc == 3)
            {
                Console.WriteLine("User: scissors, computer: scissors.");
                Console.WriteLine("Noone wins");
            }
            else if (user == 1 && pc == 2)
            {
                Console.WriteLine("User: rock, computer: paper.");
                Console.WriteLine("Paper beats rock");
                Console.WriteLine("Computer wins point");
                winner = 2;
            }
            else if (user == 1 && pc == 3)
            {
                Console.WriteLine("User: rock, computer: scissors.");
                Console.WriteLine("Rock beats scissors");
                Console.WriteLine("User wins point");
                winner = 1;
            }
            else if(user == 2 && pc == 1)
            {
                Console.WriteLine("User: paper, computer: rock.");
                Console.WriteLine("Paper beats rock");
                Console.WriteLine("User wins point");
                winner = 1;
            }
            else if (user == 2 && pc == 3)
            {
                Console.WriteLine("User: paper, computer: scissors.");
                Console.WriteLine("Scissors beat paper");
                Console.WriteLine("Computer wins point");
                winner = 2;
            }
            else if(user == 3 && pc == 1)
            {
                Console.WriteLine("User: scissors, computer: rock.");
                Console.WriteLine("Rock beats scissors");
                Console.WriteLine("Computer wins point");
                winner = 2;
            }
            else if (user == 3 && pc == 2)
            {
                Console.WriteLine("User: scissors, computer: paper.");
                Console.WriteLine("Scissors beat paper");
                Console.WriteLine("User wins point");
                winner = 1;
            }
            return winner;
        }

        public static void Game()
        {
            float userPoints = 0;
            float computerPoints = 0;
            float wins = 0;
            float loses = 0;
            float attempts = 0;
            while (true)
            {
                attempts++;
                wins = (userPoints / attempts) * 100;
                loses = (computerPoints / attempts) * 100;


                Console.Clear();
                Console.WriteLine($"Player winning percentage: {wins}%");
                Console.WriteLine($"Player losing percentage: {loses}%");
                Console.WriteLine($"Palyer score: {userPoints}");
                Console.WriteLine($"Computer score: {computerPoints}");
                string gameState = userPoints + computerPoints == 0 ? "Game just started"
                    : userPoints > computerPoints ? "User is in the lead"
                    : userPoints < computerPoints ? "Computer is in the lead"
                    : "The game is tied";
                Console.WriteLine(gameState);
                int winner = Round();
                if (winner == 1)
                {
                    userPoints++;
                }
                else if (winner == 2)
                {
                    computerPoints++;
                }
                Console.ReadLine();
            }


        }

    }
}
