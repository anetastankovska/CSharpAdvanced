// See https://aka.ms/new-console-template for more information
using SEDC.Oop.Class03.Polymorphism.Entities;

Console.WriteLine("Hello, World!");

List<Pet> pets = new List<Pet>()
{
    new Cat("meow", 2),
    new Dog("bark", "German Sheppherd"),
    new Dog("sparky", "Doga")
};

foreach (Pet pet in pets)
{
    pet.Eat();
}

Dog dog1 = new Dog();
Dog dog2 = new Dog(123);
Dog dog3 = new Dog("Bak");
Dog dog4 = new Dog("DogName", "Koker");

MethodPoly methodPoly = new MethodPoly();
methodPoly.AddNumbers(1, 2); // calls the method with int
methodPoly.AddNumbers(3.5, 4.0); // calls the method with double 
methodPoly.AddNumbers((double)3, 4); //calls the method with double
methodPoly.AddNumbers(3, 6, 9); // calls the mehod with three integers