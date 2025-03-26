namespace cwiczenia3;

public class LiquidContainer : Container, IHazardNotifier
{
    private bool Dangerous { get; }
    
    public LiquidContainer(int height, int weight, int depth, int cargoWeight, int cargoMaxWeight, bool dangerous) 
        : base(height, weight, depth, cargoWeight, cargoMaxWeight, 'L')
    {
        this.Dangerous = dangerous;
    }
    
    public void SendHazardMessage(string message)
    {
        Console.WriteLine($"{SerialNumber}: {message}");
    }

    public override void LoadContainer(int cargoWeight)
    {
        base.LoadContainer(cargoWeight);
        if (cargoWeight > CargoMaxWeight * 0.5 && Dangerous)
        {
            SendHazardMessage("Przekroczono dozwoloną masę ładunku niebezpiecznego!");
        } else if (cargoWeight > CargoMaxWeight * 0.9)
        {
            SendHazardMessage("Przekroczono dozwoloną masę ładunku niebezpiecznego!");
        }
    }
}