// See https://aka.ms/new-console-template for more information
using SEDC.Oop.Class04.GenericMethods.Entities;

Console.WriteLine("Hello, World!");

GenericMethods genericMethods = new GenericMethods();
genericMethods.PrintObject<string, int>("Something", 34);
genericMethods.PrintObject<DateTime, int>(DateTime.Now, 25);
genericMethods.PrintObject<int, string>(34, "Hello Generic Methods");

NonGenericHelper nonGenericHelper = new NonGenericHelper();
List<string> stringList = new List<string>()
{
    "Hello",
    "World",
    "Generic",
    "Methods"
};
nonGenericHelper.GoThrougList(stringList);
nonGenericHelper.GetInfoForList(stringList);

List<int> intList = new List<int>()
{
    1, 2, 3, 4, 5, 6
};

nonGenericHelper.GoThrougList(intList);
nonGenericHelper.GetInfoForList(intList);

Console.WriteLine("===================================");
GenericHelper genericHelper = new GenericHelper();
genericHelper.GoThroughList<string>(stringList);
genericHelper.GoThroughList<int>(intList);
genericHelper.GetInfoForList<string>(stringList);
genericHelper.GetInfoForList<int>(intList);

GenericClass<double> genericClass = new GenericClass<double>(3.5);
genericClass.PrintPropertyTypeAndValue();

GenericClass<bool> genericBool = new GenericClass<bool>(true);
genericBool.PrintPropertyTypeAndValue();

GenericClass<decimal> genericDecimal = new GenericClass<decimal>(5.8m);
genericDecimal.PrintPropertyTypeAndValue();

// GenericDB<int> genericDB = new GenericDB<int>() // cannot be used int as we already defined it to be object of a typr BaseEntity

GenericDB<Product> productDB = new GenericDB<Product>();
productDB.Add(new Product { Id = 1, Title = "Book", Description = "C# Basic" });
productDB.Add(new Product { Id = 2, Title = "Book", Description = "C# Advanced" });
productDB.Add(new Product { Id = 3, Title = "Book", Description = "C# Pro" });

GenericDB<Order> orderDb = new GenericDB<Order>();
orderDb.Add(new Order { Id = 4, Product = new Product { Id = 1, Title = "Book", Description = "C# Basic" }, Address = "Partizanska" });
orderDb.Add(new Order { Id = 5, Product = new Product { Id = 2, Title = "Book", Description = "C# Advanced" }, Address = "Ilindenska" });
orderDb.Add(new Order { Id = 6, Product = new Product { Id = 3, Title = "Book", Description = "C# Pro" }, Address = "Dame Gruev" });

productDB.PrintInfo();
orderDb.PrintInfo();

Product productForDelete = new Product() { Id = 4, Title = "Book", Description = "JavaScript" };
Product secondProduct = productForDelete;
productDB.DeleteItem(productForDelete);
productDB.DeleteItem(secondProduct);

productDB.Add(productForDelete);