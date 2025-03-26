namespace cwiczenia3;

public class CoolContainer : Container
{
    public ProductType Product { get; }
    public double Temperature { get; }
    
    public CoolContainer(int height, int weight, int depth, int cargoWeight, int cargoMaxWeight, ProductType product, double temperature)
        : base(height, weight, depth, cargoWeight, cargoMaxWeight, 'C')
    {
        if (temperature < ProductDict.MinTemperatures[product])
        {
            throw new ArgumentException("Temperatura za niska dla podanego produktu!");
        }
        
        this.Product = product;
        this.Temperature = temperature;
    }
}