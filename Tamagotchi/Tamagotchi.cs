using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public abstract class Tamagotchi
{
    protected int hunger;

    protected int boredom;

    private List<string> words = new List<string>() {"Hello"};

    private List<int> calorieslist = new List<int>();
   
        
    public int PlayerCalories = 10;

    public int CaloriesPerRound = 1; 

    protected bool isAlive;

    public string TamaType;
    public abstract void Tick();
    public string Name;

      public Tamagotchi()
    {
        isAlive = true;
    }

    public void Feed(int calories)
    {
        if (calories > PlayerCalories)
        {
        Console.WriteLine($"Du har inte tillräckligt med kalorier! Du har bara {PlayerCalories} kvar.");

        return;
        }

        Console.WriteLine ($"[{Name}] äter och blir mindre hungrig");
        
        //hungern med antalet kalorier endast om calories är större än noll
        hunger -= Math.Max(calories,0);
        calorieslist.Add(calories);

        //spelarens tillgängliga kalorier minskar med antalet kalorier som används
        PlayerCalories -= calories;

        //hungern kan inte bli negativ
        if (hunger < 0)
        {
            hunger = 0;
        }

         Console.WriteLine($"Du har {PlayerCalories} kalorier kvar att mata med.");
    }

    public void Hi()
    {
        int wordNum = Random.Shared.Next (words.Count);
        Console.WriteLine ($"[{Name}] säger: {words[wordNum]}");
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        Console.WriteLine ($"[{Name}] lär sig: {word}");
        words.Add(word);
        ReduceBoredom();
    }

    public void PrintStats()
    {
        //räknar ut totala kalorier som tamagotchin har matats med
        int totalCalories = calorieslist.Sum(); 
        Console.WriteLine($"Namn: {Name}|Typ: {TamaType} | Hunger: {hunger} | Boredom: {boredom}  Ordförråd: {words.Count} ord | Kalorier: {totalCalories} | Kalorier kvar: {PlayerCalories}"  );
    }

    public bool GetAlive()
    {
        return isAlive;
    }
    

    
    private void ReduceBoredom()
    {
        Console.WriteLine($"[{Name}] är nu mindre uttråkad");
        boredom -= 2;

        //Boredom kan inte bli negativ
        if (boredom < 0)
        {
            boredom = 0;
        }
    }






}
