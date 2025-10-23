public class Product
{
    public ITechnic Tech { get; set; }
    public int Count { get; set; }
    public decimal Price { get; set; }

    public Product(ITechnic tech, int count, decimal price)
    {
        Tech = tech;
        Count = count;
        Price = price;
    }

    public void Print()
    {
        Console.WriteLine($"Модель: {Tech.Model}");
        Console.WriteLine($"Тип: {Tech.GetType().Name}");
        Console.WriteLine($"Количество: {Count}");
        Console.WriteLine($"Цена: {Price} руб.");
        Console.WriteLine("---");
    }
    

}