while(true == true) //kör i all oändlighet
{
    Tamagotchi tama = new Tamagotchi();
    System.Console.WriteLine("Döp din tamagotchi");
    string Name = Console.ReadLine();

    System.Console.WriteLine("Välkommen till tamagotchi spelet");
    System.Console.WriteLine($"Skriv in Hi, Feed, Teach eller Reduce Boredom för att interagera med {Name}");

    string action = Console.ReadLine();
    if (action == "Hi")
    {
        tama.Hi();
    }
    else if (action == "Feed")
    {
        tama.Feed();
    }
    else if (action == "Teach")
    {
        System.Console.WriteLine("What phrase would you like me to learn?");
        string r = System.Console.ReadLine();
        tama.Teach(r);
        System.Console.WriteLine($"thank you for teaching me the following phrase:{r}");

    }
    else if (action == "Reduce Boredom")
    {
        tama.ReduceBoredom();
    }

    tama.Tick();
    tama.PrintStats();



    Console.ReadLine();
}