public class Tamagotchi
{
    public string Name;
    
    


    private Random random = new Random();

    private bool isAlive = true;

    private List<string> words = new List<string>();

    private int Boredom = 0;

    private int Hunger = 0;

    public void Feed()
    {
        Hunger += 5;
        if (Hunger > 20)
        {
            Hunger = 20;
        }
    }

    public void Hi()
    {

    }

    public void Teach(string word)
    {

    }

    public void Tick()
    {
        Hunger += 1;
        Boredom += 1;
    }

    public void PrintStats()
    {
        System.Console.WriteLine("Hunger: " + Hunger);
        System.Console.WriteLine("Boredom: " + Boredom);
        if (isAlive == true)
        {
            System.Console.WriteLine("Tamagochin lever");                
        }

    }

    public bool GetAlive()
    {
        return true;
    }

    private void ReduceBoredom()
    {

    }
}