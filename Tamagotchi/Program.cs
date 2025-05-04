Console.WriteLine("Välkommen till tamagotchi");
Tamagotchi myTama;

Tamagotchi getTamagochi()
{


    int tamatype = Random.Shared.Next(0,3);
    if (tamatype == 1)
    {
        return new BoredTama();
    }
    else
    {
        return new HungryTama();
    }
     
}
// Tamagotchi myTama = new Tamagotchi();



myTama = getTamagochi();
Console.WriteLine($"Din tamagotchi typ är {myTama.type}");
Console.WriteLine("Välj ett namn för din tamagotchi");
myTama.name = Console.ReadLine();

Console.WriteLine($"Bra, {myTama.name} är ett fantastiskt namn!");

while (myTama.GetAlive() == true)
{
    Console.Clear ();
    myTama.PrintStats();
    Console.WriteLine ("Vad vill du göra?");
    Console.WriteLine ($"1. Lära {myTama.name} ett nytt ord ");
    Console.WriteLine ($"2. Prata med {myTama.name}");
    Console.WriteLine ($"3. Mata {myTama.name}");
    Console.WriteLine ($"4. Ingenting");

    string doWhat = Console.ReadLine ();

    if (doWhat == "1")
    {
        Console.WriteLine("Vilket ord?");
        string word = Console.ReadLine();
        myTama.teach(word);
    }

    else if (doWhat == "2")
    {
        myTama.Hi();
    }

    else if (doWhat == "3")
    {
        // int calories = int.Parse(Console.ReadLine());
        
        // string calories = Console.ReadLine();
        int result;
        bool success = false;
        int calories = -1;
        while(!success)
        {

            success = int.TryParse(Console.ReadLine(), out calories);

        }
        myTama.feed(calories);
    }

    else 
    {
        Console.WriteLine("Gör ingenting...");
    }

    myTama.tick();
    Console.WriteLine ("Klicka för att för att fortsätta");
    Console.ReadLine ();


}   

Console.WriteLine ($"{myTama} är död");


Console.ReadLine();