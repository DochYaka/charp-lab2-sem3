class PC : Tech
{
    public Components Components { get; set; }

    public PC() : base("Model", 1)
    {
        Components components = new Components();
    }

    public PC(string model, int weight, Components components) : base(model, weight)
    {
        Components = components;
    }

    public override string ToString()
    {
        return $"Components: {Components}";
    }

    public override void Print()
    {
        base.Print();
        Components.Print();
    }
   
}
