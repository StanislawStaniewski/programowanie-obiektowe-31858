namespace Lab3;

public abstract class Vehicle
{
    public double EngineCapacity { get; protected set; }
    public string Model { get; private set; }
    public int Year { get; private set; }

    public Vehicle(double engineCapacity, string model, int year)
    {
        EngineCapacity = engineCapacity;
        Model = model;
        Year = year;
    }

    public virtual void Start()
    {
        Console.WriteLine("Vehicle started");
    }

    public void Stop()
    {
        Console.WriteLine("Vehicle stopped");
    }

    public abstract void Test();
}