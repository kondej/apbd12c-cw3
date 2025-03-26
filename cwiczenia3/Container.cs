namespace cwiczenia3;

public class Container
{
    public int Height { get; }
    public int Weight { get; }
    public int Depth { get; }
    public int CargoMaxWeight { get; }
    public int CargoWeight { get; set; }
    public string SerialNumber { get; }
    private static int _serialNumberCounter = 1; 
    
    protected Container(int height, int weight, int depth, int cargoWeight, int cargoMaxWeight, char type)
    {
        this.Height = height;
        this.Weight = weight;
        this.Depth = depth;
        this.CargoMaxWeight = cargoMaxWeight;
        this.CargoWeight = cargoWeight;
        this.SerialNumber = GenerateSerialNumber(type);
    }

    protected string GenerateSerialNumber(char type)
    {
        return $"KON-{_serialNumberCounter++}-{type}";
    }
    
    public virtual void LoadContainer(int cargoWeight)
    {
        if (cargoWeight > CargoMaxWeight)
        {
            throw new OverfillException();
        }
        
        CargoWeight = cargoWeight;
    }
    
    public virtual void EmptyContainer()
    {
        CargoWeight = 0;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"\nKontener numer seryjny: {SerialNumber}");
        Console.WriteLine($"Waga własna: {CargoWeight} kg");
        Console.WriteLine($"Wysokość kontenera: {Height} cm");
        Console.WriteLine($"Głębokość kontenera: {Depth} cm");
        Console.WriteLine($"Maksymalna ładowność: {CargoMaxWeight} kg");
        Console.WriteLine($"Waga ładunku: {CargoWeight}");
    }
}