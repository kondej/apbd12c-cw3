namespace cwiczenia3;

public class Ship
{
    private List<Container> _containers = new List<Container>();
    public int Speed { get; }
    public int MaxContainerCount { get; }
    public int MaxContainerWeight { get; }
    
    public Ship(int speed, int maxContainerCount, int maxContainerWeight)
    {
        this.Speed = speed;
        this.MaxContainerCount = maxContainerCount;
        this.MaxContainerWeight = maxContainerWeight;
    }

    public void LoadContainer(Container container)
    {
        _containers.Add(container);
    }

    public void LoadContainersList(List<Container> containers)
    {
        _containers.AddRange(containers);
    }

    public void UnloadContainer(Container container)
    {
        _containers.Remove(container);
    }

    public void ReplaceContainer(string oldContainerSerial, Container newContainer)
    {
        Container? containerToReplace = null;
        
        foreach (Container container in _containers)
        {
            if (container.SerialNumber == oldContainerSerial)
            {
                containerToReplace = container;
                break;
            }
        }
        
        if (containerToReplace != null)
        {
            _containers.Remove(containerToReplace);
            _containers.Add(newContainer);
        }
        else
        {
            Console.WriteLine($"Nie znaleziono kontenera o numerze {oldContainerSerial}.");
        }
    }

    public static void MoveContainer(Container container, Ship fromShip, Ship toShip)
    {
        fromShip.UnloadContainer(container);
        toShip.LoadContainer(container);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"\nPrędkość: {Speed}");
        Console.WriteLine($"Maksymalna liczba kontenerów: {MaxContainerCount}");
        Console.WriteLine($"Maksymalna waga kontenerów: {MaxContainerWeight}");
        Console.WriteLine("Załadowane kontenery:");

        foreach (Container container in _containers)
        {
            Console.WriteLine(container.SerialNumber);
        }
    }
}