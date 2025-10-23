public sealed class Printer : Tech
{
    public int SpeedPrint { get; set; }
    public bool TouchScreen { get; set; }

    public Printer() : base("Model", 1)
    {
        SpeedPrint = 1;
        TouchScreen = false;
    }

    public Printer(string model, int weight, int SpeedPrint, bool touchScreen) : base(model, weight)
    {
        this.SpeedPrint = (SpeedPrint < 0 || SpeedPrint > 10) ? 1 : SpeedPrint;
        this.TouchScreen = touchScreen;
    }

    public override string ToString()
    {
        return $"Скорость печати: {SpeedPrint}, TouchScreen: {TouchScreen}";
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Скорость печати {SpeedPrint} шт\\с.");
        Console.WriteLine($"Сенсорный экран: {(TouchScreen ? "Есть" : "Нет")}");
    }
    
}