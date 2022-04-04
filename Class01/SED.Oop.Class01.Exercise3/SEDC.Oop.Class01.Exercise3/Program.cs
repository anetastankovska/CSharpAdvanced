// See https://aka.ms/new-console-template for more information
using SEDC.Oop.Class01.Exercise3.Models;

Service service = new Service();
Console.WriteLine("Please select which role you want to play: \n1. Rock \n2. Paper \n3. Scissors");
int validInt = service.ValidateInput(1, 3);



User player = new User(validInt);
service.ShowPicks(validInt);