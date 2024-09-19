Console.WriteLine("Välkommen till tamagotchi");

Tamagotchi myTama = new Tamagotchi();

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

    if (doWhat == "2")
    {
        myTama.Hi();
    }

    if (doWhat == "3")
    {
        myTama.feed();
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