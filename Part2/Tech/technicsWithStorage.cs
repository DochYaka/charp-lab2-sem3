public class TechWithStorage : Tech
{
    public int Storage { get; set; }
    public int RAM { get; set; }

    public TechWithStorage() : base("Model", 1)
    {
        Storage = 64;
        RAM = 8;
    }

    public TechWithStorage(string model, int weight, int Storage, int RAM) : base(model, 1)
    {
        this.Storage = (Storage < 64 || Storage > 512) ? 64 : Storage;
        this.RAM = (RAM < 8 || RAM > 64) ? 8 : RAM;
    }

    public override void Print()
    {
        base.Print();
        Console.WriteLine($"Размер хранилища в гб: {Storage}");
        Console.WriteLine($"Объём оперативной памяти в гб: {RAM}");
    }
}