Tamagotchi tama = new Tamagotchi();
System.Console.WriteLine("Döp din tamagotchi");
string Name = Console.ReadLine();

System.Console.WriteLine("Välkommen till tamagotchi spelet");
System.Console.WriteLine($"Skriv in Hi, Feed, Teach eller Reduce Boredom för att interagera med {Name}");

string action = Console.ReadLine();
if (action == "hi")
{
    tama.Hi();
}
else if (action == "Feed")
{
    tama.Feed();
}
else if (action == "Teach")
{
    tama.Teach();
}
else if (action == "Reduce Boredom")
{
    tama.ReduceBoredom();
}

tama.Tick();
tama.PrintStats();



Console.ReadLine();