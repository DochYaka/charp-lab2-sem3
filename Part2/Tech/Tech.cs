
public class Tech : ITechnic
{
    public string Model { get; set; }
    public int Weight { get; set; }

    public Tech()
    {
        Model = "Model";
        Weight = 1;
    }

    public Tech(string model, int weight)
    {
        this.Model = string.IsNullOrWhiteSpace(model) ? "Model" : model;
        this.Weight = (weight < 1 || weight > 2000) ? 1 : weight;
    }

    public virtual void Print()
    {
        Console.WriteLine($"\nМодель: {Model}");
        Console.WriteLine($"Вес: {Weight} кг");
    }

    public void ChangeModel(string model) => Model = string.IsNullOrWhiteSpace(model) ? "Model" : model;
    public void ChangeWeight(int weight) => Weight = (weight < 1 || weight > 2000) ? 1 : weight;
}