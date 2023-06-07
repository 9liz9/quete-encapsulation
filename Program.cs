namespace S03_encapsulation;

class Program
{
    static void Main(string[] args)
    {
        BeerEncapsulator machine = new BeerEncapsulator();

        machine.AddBeer(100); 

        int bottlesToProduce = 10;
        int producedBottles = machine.ProduceEncapsulatedBeerBottles(bottlesToProduce);

        Console.WriteLine($"Produit {producedBottles} bouteilles.");
        Console.WriteLine($"Volume de bière restant dans la machine: {machine.getAvailableBeerVolume()} centilitres.");
        Console.WriteLine($"Bouteilles laissées dans la machine: {machine.getAvailableBottles()}.");
        Console.WriteLine($"Capsules restantes dans la machine: {machine.getAvailableCapsules()}.");
    }
}

