public enum TypeScan {Undefined, FastSpeed, Clean, Correctly}

public class Scaner : Tech
{
    public TypeScan TypeScan { get; set; }

    public Scaner() : base("Model", 1)
    {
        TypeScan = TypeScan.Undefined;
    }

    public Scaner(string model, int weight, TypeScan TypeScan) : base(model, weight)
    {
        this.TypeScan = (TypeScan == TypeScan.FastSpeed || TypeScan == TypeScan.Clean || TypeScan == TypeScan.Correctly) ? TypeScan.Undefined : TypeScan;
    }

    public override string ToString()
    {
        if (TypeScan == TypeScan.FastSpeed) return $"Тип сканирования: {TypeScan} (возможны ошибки)";
        if (TypeScan == TypeScan.Clean) return $"Тип сканирования: {TypeScan} (средняя скорость, вероятность ошибки маленькая)";
        if (TypeScan == TypeScan.Correctly) return $"Тип сканирования: {TypeScan} (долгий безошибочный скан)";
        return $"{TypeScan}";
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Тип сканирования у сканера: {TypeScan}");
    }

}