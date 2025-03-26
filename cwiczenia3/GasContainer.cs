namespace cwiczenia3;

public class GasContainer : Container, IHazardNotifier
{
    public int Pressure { get; set; }
    
    public GasContainer(int height, int weight, int depth, int cargoWeight, int cargoMaxWeight) 
        : base(height, weight, depth, cargoWeight, cargoMaxWeight, 'G')
    {
    }

    public void SendHazardMessage(string message)
    {
        Console.WriteLine($"{SerialNumber}: {message}");
    }

    public override void EmptyContainer()
    {
        CargoWeight = Convert.ToInt32(CargoWeight * 0.05);
    }
}