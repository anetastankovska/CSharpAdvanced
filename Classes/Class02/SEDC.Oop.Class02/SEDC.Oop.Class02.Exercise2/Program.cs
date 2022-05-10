
// See https://aka.ms/new-console-template for more information
using SEDC.Oop.Class02.Exercise2.Models;


//Create interfaces called IAnimal, IDog, ICat
//IAnimal : Contains method PrintAnimal
//IDog - Contains method Bark
//ICat - Contains method Eat that gets parameter food of type string
//Create an abstract class Animal (you choose the properties) that implements IAnimal, with abstract method PrintAnimal
//Create class Dog that implements IDog and inherits from Animal. Implement PrintAnimal but also Bark.
//Create class Cat that implements ICat and inherits from Animal. Implement PrintAnimal but also Eat.
//Create several objects and test the method calls
//** Bonus

//Create a list of Animal and add members that are of type Cat and Dog.
//Iterate the list, use GetType for each member to see the type of animal. If it is a dog call its bark method, if it is a cat call the Eat method.


Cat mica = new Cat("Micka", 6, "yellow");
mica.PrintAnimal();
mica.Eat("Royal canin");
mica.GetType().GetInterfaces().ToList().ForEach(x => Console.WriteLine(x.Name));

Dog boo = new Dog("Boo", 1, "brown");
boo.PrintAnimal();
boo.GetType().GetInterfaces().ToList().ForEach(x => Console.WriteLine(x.Name));

List<Animal> animals = new List<Animal>()
{
    new Dog ("Lucky", 2, "white"),
    new Cat ("Toby", 0, "beige"),
    new Dog ("Sharko", 1, "brown"),
    new Cat ("Garfield", 3, "black")
};

foreach (Animal animal in animals)
{   
    if(animal.GetType() == typeof(Dog)){
        (animal as Dog).Bark();
    }
    else
    {
        (animal as Cat).Eat("food");
    }
    
}

