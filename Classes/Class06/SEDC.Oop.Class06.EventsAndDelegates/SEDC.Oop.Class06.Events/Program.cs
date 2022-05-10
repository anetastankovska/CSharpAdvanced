// See https://aka.ms/new-console-template for more information
using SEDC.Oop.Class06.Events.Entities;

Market tineks = new Market()
{
    Name = "Tineks",
    CurrentProductType = ProductType.Food
};

Market reptil = new Market()
{
    Name = "Reptil",
    CurrentProductType = ProductType.Cosmetics
};

Market neptun = new Market()
{
    Name = "Neptun",
    CurrentProductType = ProductType.Electronic
};

User ivan = new User("Ivan", "Djikovski", 34, "ivan.djikovski@gmail.com");
User vlatko = new User("Vlatko", "Tasevski", 25, "vlatko.tasevski@gmail.com");
User aneta = new User("Aneta", "Stankovska", 30, "aneta.stankovska@gmail.com");
User stefan = new User("Stefan", "Ivanovski", 31, "stefan.ivanovski@gmail.com");

tineks.SubscribeToPromotion(ivan.ReadPromotion, ivan.Email);
tineks.SubscribeToPromotion(vlatko.ReadPromotion, vlatko.Email);
tineks.SubscribeToPromotion(stefan.ReadPromotion, stefan.Email);

Console.WriteLine("============================================");

neptun.SubscribeToPromotion(aneta.ReadPromotion, aneta.Email);
neptun.SubscribeToPromotion(stefan.ReadPromotion, stefan.Email);

Console.WriteLine("============================================");

tineks.Unsubscribe(vlatko.ReadPromotion, vlatko.Email);

tineks.Send();

reptil.SubscribeToPromotion(ReadPromotion, "Console writeline");
//reptil.SubscribeToPromotion((type, marketName) =>
//{
//    Console.WriteLine($"Subscription from anonimous method: Promotion for {type} at {marketName}") , "fake email";
//});

reptil.Send();

static void ReadPromotion(ProductType type, string marketName)
{
    Console.WriteLine($"Subscription from main method: Promotion for {type} at {marketName}");
}



