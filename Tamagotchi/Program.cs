Console.WriteLine("Välkommen till tamagotchi");
Tamagotchi myTama;

Tamagotchi getTamagochi()
{

    //slumpar vilken typ av tamagotchi som skapas
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



//skapar en tamagotchi
myTama = getTamagochi();

//typ av tamagotchi presenteras
Console.WriteLine($"Din tamagotchi typ är {myTama.TamaType}");
Console.WriteLine("Välj ett namn för din tamagotchi");
myTama.Name = Console.ReadLine();

Console.WriteLine($"Bra, {myTama.Name} är ett fantastiskt namn!");

//Körs sålänge tamagotchin lever
while (myTama.GetAlive() == true)
{
    Console.Clear ();
    myTama.PrintStats();
    Console.WriteLine ("Vad vill du göra?");
    Console.WriteLine ($"1. Lära {myTama.Name} ett nytt ord ");
    Console.WriteLine ($"2. Prata med {myTama.Name}");
    Console.WriteLine ($"3. Mata {myTama.Name}");
    Console.WriteLine ($"4. Ingenting");

    string doWhat = Console.ReadLine ();

    if (doWhat == "1")
    {
        Console.WriteLine("Vilket ord?");
        string word = Console.ReadLine();
        myTama.Teach(word);
    }

    else if (doWhat == "2")
    {
        myTama.Hi();    
    }

    else if (doWhat == "3")
    {

        Console.WriteLine("Hur många kalorier?");
        
        bool success = false;
        int calories = 0;
        while(!success)
        {
            //konverterar string från användaren till en int
            success = int.TryParse(Console.ReadLine(), out calories);

        }
        
        
        myTama.Feed(calories);

    }

    else 
    {
        Console.WriteLine("Gör ingenting...");
    }

    //tick körs varje gång
    myTama.Tick();
    Console.WriteLine ("Klicka för att för att fortsätta");
    Console.ReadLine ();


}   

Console.WriteLine ($"{myTama} är död");


Console.ReadLine();