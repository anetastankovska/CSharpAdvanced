// See https://aka.ms/new-console-template for more information

//Create a class called Dog that has:
//  - Id, Name, Color, Bark() - Prints “Bark Bark”
//  - A static method Validate() -Checks if dog has all 3 properties, if Id is not less than 0 and Name is 2 characters or longer
//Create a static class called DogShelter that has:
//  - List of Dogs
//  - PrintAll() -prints all dogs from List of Dogs
//Create 3 Dog objects, call validate on them to see if they are okay, add them in the List of Dogs and call PrintAll()

using SEDC.Oop.Class02.Exercise1.Models;

Dog dog1 = new Dog(01,"Dino", "black");
Dog dog2 = new Dog(02, "Badi", "brown");
Dog dog3 = new Dog(03, "Tobi", "white");

Console.WriteLine(Dog.Validate(dog1));
Console.WriteLine(Dog.Validate(dog2));
Console.WriteLine(Dog.Validate(dog3));

DogShelter.Dogs.Add(dog1);
DogShelter.Dogs.Add(dog2);
DogShelter.Dogs.Add(dog3);

DogShelter.PrintAllDogs();
DogShelter.GetDogData1();
DogShelter.PrintAllDogs();

