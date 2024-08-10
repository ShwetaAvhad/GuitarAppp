using GuitarAppp;
public class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Guitar App");     
        
        Inventory inventory = new Inventory();
        inventory.AddGuitar("fd101", 1400, new GuitarSpec(Builder.Fender, "stratocastor", GuitarAppp.Type.Electric,Wood.Alder, Wood.Alder));
        inventory.AddGuitar("fd102", 1500, new GuitarSpec(Builder.Martin, "stratocastor", GuitarAppp.Type.Acoustic,Wood.Indian_RoseWood, Wood.Cedar));
        inventory.AddGuitar("fd103", 1000, new GuitarSpec(Builder.Gibson, "stratocastor", GuitarAppp.Type.Electric, Wood.Cedar, Wood.Sitka));
        inventory.AddGuitar("fd104", 1700, new GuitarSpec(Builder.Martin, "stratocastor", GuitarAppp.Type.Acoustic, Wood.Indian_RoseWood, Wood.Brazilian_RoseWood));
        inventory.AddGuitar("fd105", 2500, new GuitarSpec(Builder.PRS, "stratocastor", GuitarAppp.Type.Acoustic, Wood.Brazilian_RoseWood, Wood.Cedar));

        GuitarSpec userInput=new GuitarSpec(Builder.Martin, "stratocastor", GuitarAppp.Type.Acoustic,Wood.Indian_RoseWood, Wood.Brazilian_RoseWood);
        List<Guitar> matchingGuitars=inventory.SearchGuitar(userInput);
        
        if (matchingGuitars != null)
        {
            Console.WriteLine("You might like this");            
            foreach(Guitar guitar in matchingGuitars)
            {
                Inventory.PrintGuitar(guitar);
            }    
        }
        else
        {
            Console.WriteLine("Sorry We Have Nothing For You");
        }
    }
}