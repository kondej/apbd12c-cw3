namespace cwiczenia3;

public class ProductDict
{
    public static readonly Dictionary<ProductType, double> MinTemperatures = new Dictionary<ProductType, double>
    {
        { ProductType.Bananas, 13.3 },
        { ProductType.Chocolate, 18.0 },
        { ProductType.Fish, 2.0 },
        { ProductType.Meat, -15.0 },
        { ProductType.IceCream, -18.0 },
        { ProductType.FrozenPizza, -30.0 },
        { ProductType.Cheese, 7.2 },
        { ProductType.Sausages, 5.0 },
        { ProductType.Butter, 20.5 },
        { ProductType.Eggs, 19.0 },
    };
}