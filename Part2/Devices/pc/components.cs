public class Components : IString
{
    public bool MotherBoard { get; set; }
    public bool CPU { get; set; }
    public bool PowerUnit { get; set; }
    public bool Storage { get; set; }
    public bool RAM { get; set; }

    public Components() {}

    public Components(bool motherBoard, bool cpu, bool powerUnit, bool storage, bool ram)
    {
        MotherBoard = motherBoard;
        CPU = cpu;
        PowerUnit = powerUnit;
        Storage = storage;
        RAM = ram;
    }

    // Переопределение ToString()
    public override string ToString()
    {
        return $"MB={MotherBoard}, CPU={CPU}, PU={PowerUnit}, Storage={Storage}, RAM={RAM}";
    }
    
    // Переопределение Equals()
    public override bool Equals(object obj)
    {
        if (obj is Components other)
        {
            return MotherBoard == other.MotherBoard &&
                   CPU == other.CPU &&
                   PowerUnit == other.PowerUnit &&
                   Storage == other.Storage &&
                   RAM == other.RAM;
        }
        return false;
    }

    // Переопределение GetHashCode()
    public override int GetHashCode()
    {
        return HashCode.Combine(MotherBoard, CPU, PowerUnit, Storage, RAM);
    }

    public void Print()
    {
        Console.WriteLine($"Материнская плата: {MotherBoard}");
        Console.WriteLine($"Центральный процессор: {CPU}");
        Console.WriteLine($"Блок питания: {PowerUnit}");
        Console.WriteLine($"Хранилище данных: {Storage}");
        Console.WriteLine($"Оперативная память: {RAM}");
    }
}