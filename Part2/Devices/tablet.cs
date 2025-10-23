public enum TechOfScreen { Undefined, LCD, OLED, AMOLED }

public class Tablet : TechWithStorage
{
    public int ScreenSize { get; set; }
    public TechOfScreen ScreenTech { get; set; }

    public Tablet()
        : base("Model", 1, 64, 8)
    {
        ScreenSize = 5;
        ScreenTech = TechOfScreen.Undefined;
    }

    public Tablet(string model, int weight, int Storage, int RAM, int screenSize, TechOfScreen screenTech)
        : base(model, weight, Storage, RAM)
    {
        this.ScreenSize = (screenSize < 1 || screenSize > 10) ? 5 : screenSize;
        this.ScreenTech = (screenTech == TechOfScreen.LCD || screenTech == TechOfScreen.OLED || screenTech == TechOfScreen.AMOLED)
            ? screenTech : TechOfScreen.Undefined;
    }

    public override string ToString()
    {
        return $"Диагональ экрана: {ScreenSize}, Технология экрана: {ScreenTech}";
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Размер экрана: {ScreenSize} дюймов");
        Console.WriteLine($"Тип экрана: {ScreenTech}");
    }
}
