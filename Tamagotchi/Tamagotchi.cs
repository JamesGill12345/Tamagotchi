public class Tamagotchi
{
    public string Name;
    
    private Random random = new Random();

    private bool isAlive = true;

    private List<string> words = new List<string>();
    
    private int Boredom = 3;

    private int Hunger = 3;


    public Tamagotchi()
    {
        words.Add("hello!");
        words.Add("Good morning!");
        words.Add("yo");
    }

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
        int r = random.Next(words.Count);
        System.Console.WriteLine(words[r]);
    }

    public void Teach(string word)
    {
        words.Add(word);
    }

    public void Tick()
    {
        Hunger -= 1;
        Boredom -= 1;

        if (Hunger == 20 && Boredom == 20)
        {
            isAlive = false;
        }
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
        return isAlive;   
    }

    public void ReduceBoredom()
    {
        Boredom += 2;
        if (Boredom > 20)
        {
            Boredom = 20;
        }
    }
}