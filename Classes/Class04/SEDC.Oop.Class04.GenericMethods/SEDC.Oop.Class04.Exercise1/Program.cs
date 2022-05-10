// See https://aka.ms/new-console-template for more information
using SEDC.Oop.Class04.Exercise1.Entities;

Console.WriteLine("Hello, World!");

PetStore<Dog> dogStore = new PetStore<Dog>();
dogStore.Add(new Dog("Tobi", "Maltezer", 1, "fish"));
dogStore.Add(new Dog("Boo", "Yorkie", 2, "salad"));

PetStore<Cat> catStore = new PetStore<Cat>();
catStore.Add(new Cat("Fifi", "Persian", 3));
catStore.Add(new Cat("Kitty", "Siam", 6));

PetStore<Fish> fishStore = new PetStore<Fish>();
fishStore.Add(new Fish("Nemo", "pastrmka", 3, "Red", 6));
fishStore.Add(new Fish("GoldFish", "goldenFish", 1, "Gold", 2));

dogStore.PrintPets();
catStore.PrintPets();
fishStore.PrintPets();
