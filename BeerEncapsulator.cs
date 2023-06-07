namespace S03_encapsulation;

public class BeerEncapsulator
{
    private decimal _availableBeerVolume;
    private int _availableBottles;
    private int _availableCapsules;

    public decimal getAvailableBeerVolume() { 
        return _availableBeerVolume; 
        }

    public int getAvailableBottles(){
        return _availableBottles;
    }

    public int getAvailableCapsules(){
        return _availableCapsules;
    }

    public void AddBeer(decimal volume)
    {
        _availableBeerVolume += volume;
    }

    public int ProduceEncapsulatedBeerBottles(int numberOfBottles)
    {
        int bottlesProduced = 0;

        for (int i = 0; i < numberOfBottles; i++)
        {
            if (_availableBeerVolume >= 33 && _availableBottles >= 1 && _availableCapsules >= 1)
            {
                _availableBeerVolume -= 33;
                _availableBottles--;
                _availableCapsules--;
                bottlesProduced++;
            }
            else
            {
                break;
            }
        }

        if (bottlesProduced < numberOfBottles)
        {
            int beerNeeded = numberOfBottles - bottlesProduced;
            int bottlesNeeded = numberOfBottles - bottlesProduced;
            int capsulesNeeded = numberOfBottles - bottlesProduced;

            Console.WriteLine($"Pas assez de composants disponibles. Ajouter {beerNeeded} bières, {bottlesNeeded} bouteilles, {capsulesNeeded} capsules.");
        }

        return bottlesProduced;
    }
}