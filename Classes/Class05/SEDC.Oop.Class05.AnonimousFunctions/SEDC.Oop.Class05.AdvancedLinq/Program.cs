// See https://aka.ms/new-console-template for more information

List<Order> orderList = new List<Order>
{
    new Order{Id = 1, Name = "Order1", OrderStatus = OrderStatus.Processing, Quantity = 30},
    new Order{Id = 2, Name ="Order2", OrderStatus=OrderStatus.Shipped, Quantity = 15},
    new Order{Id = 5, Name ="Order5", OrderStatus=OrderStatus.Delivered, Quantity = 10},
    new Order{Id = 3, Name ="Order3", OrderStatus=OrderStatus.Processing, Quantity = 5},
    new Order{Id = 4, Name ="Order4", OrderStatus=OrderStatus.Delivered, Quantity = 3},
    new Order{Id = 7, Name ="Order7", OrderStatus=OrderStatus.Shipped, Quantity = 6},
    new Order{Id = 6, Name ="Order6", OrderStatus=OrderStatus.Delivered, Quantity = 17},
    new Order{Id = 11, Name ="Order11", OrderStatus=OrderStatus.Processing, Quantity = 7},
    new Order{Id = 9, Name ="Order9", OrderStatus=OrderStatus.Shipped, Quantity = 22},
    new Order{Id = 10, Name ="Order10", OrderStatus=OrderStatus.Delivered, Quantity = 18},
};

List<Order> copyList = orderList.Select(x => x).ToList();

Console.WriteLine("Original list");
orderList.ForEach((x) => Console.WriteLine(x));

orderList.FirstOrDefault(x => x.Id == 1).Name = "Changed order 1";

Console.WriteLine("Copied list");
copyList.ForEach((x) => Console.WriteLine(x));

List<Order> realCopyList = orderList.Select(x => new Order
{
    Id = x.Id,
    Name = x.Name,
    OrderStatus = x.OrderStatus,
    Quantity = x.Quantity,
}).ToList();

orderList.FirstOrDefault(x => x.Id == 4).Name = "Changed order 4";

Console.WriteLine("Real copy list");
realCopyList.ForEach((x) => Console.WriteLine(x));


int sumOfAllQuantities = orderList.Sum(order => order.Quantity);
Console.WriteLine($"The sum is {sumOfAllQuantities}");

int max = orderList.Max(order => order.Quantity);
Console.WriteLine($"The max quantity is {max}");

Order maxOrder = orderList.FirstOrDefault(x => x.Quantity == max);
Console.WriteLine(maxOrder);

double averageQuantity = orderList.Average(x => x.Quantity);

List<Order> aboveAverage = orderList.Where(x => x.Quantity > averageQuantity).ToList();
Console.WriteLine("The average quantity is:");
aboveAverage.ForEach (x => Console.WriteLine(x));

Console.WriteLine("Ordered list: ");
var orderedOrderList = orderList.OrderBy(x => x.Id).ToList();
orderedOrderList.ForEach(x => Console.WriteLine(x));

Console.WriteLine("Ordered list descending: ");
var orderedOrderListDesc = orderList.OrderByDescending(x => x.Id).ToList();
orderedOrderListDesc.ForEach(x => Console.WriteLine(x));

Console.WriteLine("Ordered by string:");
List<Order> orderedByString = orderList.OrderBy(x => x.Name).ToList();
orderedByString.ForEach(x => Console.WriteLine(x));

Console.WriteLine("Grouped orders by Staus");
var groupedOrders = orderList.GroupBy(x => x.OrderStatus).ToList();
foreach (var orderGrouping in groupedOrders)
{
    Console.WriteLine(orderGrouping.Key);
    foreach (var order in orderGrouping)
    {
        Console.WriteLine(order);
    }
}

public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public OrderStatus OrderStatus { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, quantity: {Quantity}, order status: {OrderStatus}";
    }
}

public enum OrderStatus
{
    Processing, 
    Shipped, 
    Delivered
}
