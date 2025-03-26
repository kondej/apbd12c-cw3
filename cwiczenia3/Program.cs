namespace cwiczenia3;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            CoolContainer bananas = new CoolContainer(400, 2000, 300, 0, 1000, ProductType.Bananas, 14);
            bananas.LoadContainer(900);

            GasContainer helium = new GasContainer(500, 1000, 400, 0, 500);
            helium.LoadContainer(450);
            helium.Pressure = 5;
            helium.SendHazardMessage("Sprawdź ciśnienie!");

            LiquidContainer explosiveMilk = new LiquidContainer(400, 1500, 1000, 0, 1100, true);
            explosiveMilk.LoadContainer(1000);
            explosiveMilk.LoadContainer(200);
            
            LiquidContainer water = new LiquidContainer(400, 1500, 1000, 0, 1100, false);
            water.LoadContainer(800);
            
            List<Container> containers = new List<Container>();
            containers.Add(helium);
            containers.Add(explosiveMilk);
            containers.Add(water);

            Ship albatros = new Ship(50, 25, 50000);
            Ship baracuda = new Ship(70, 15, 30000);
            
            albatros.LoadContainer(bananas);
            albatros.LoadContainersList(containers);
            albatros.UnloadContainer(water);
            
            water.EmptyContainer();
            
            albatros.ReplaceContainer("KON-1-C", water);
            
            Ship.MoveContainer(helium, albatros, baracuda);
            
            explosiveMilk.PrintInfo();
            water.PrintInfo();
            
            albatros.PrintInfo();
            baracuda.PrintInfo();
            
            helium.PrintInfo();
            helium.EmptyContainer();
            helium.PrintInfo();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}