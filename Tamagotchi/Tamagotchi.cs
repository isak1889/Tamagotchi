using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public abstract class Tamagotchi
{
    protected int hunger;

    protected int boredom;

    private List<string> words = new List<string>() {"Hello"};

    private List<int> calorieslist = new List<int>();
   
        
    public int playerCalories = 10;

    public int caloriesPerRound = 2; 

    protected bool isAlive;

    public string type;
    public abstract void tick();
    public string name;

      public Tamagotchi()
    {
        isAlive = true;
    }

    public void feed(int calories)
    {
        if (calories > playerCalories)
        {
        Console.WriteLine($"Du har inte tillräckligt med kalorier! Du har bara {playerCalories} kvar.");

        return;
        }

        Console.WriteLine ($"[{name}] äter och blir mindre hungrig");
        //hunger -= Random.Shared.Next(0,3);
        hunger -= Math.Max(calories,0);
        calorieslist.Add(calories);
        playerCalories -= calories;

        if (hunger < 0)
        {
            hunger = 0;
        }

         Console.WriteLine($"Du har {playerCalories} kalorier kvar att mata med.");
    }

    public void Hi()
    {
        int wordNum = Random.Shared.Next (words.Count);
        Console.WriteLine ($"[{name}] säger: {words[wordNum]}");
        ReduceBoredom();
    }

    public void teach(string word)
    {
        Console.WriteLine ($"[{name}] lär sig: {word}");
        words.Add(word);
        ReduceBoredom();
    }

    // public void tick()
    // {
    //     hunger ++;
    //     boredom ++;

    //     if (hunger > 10 || boredom > 10)
    //     {
    //         isAlive = false;
    //     }
    // }

    public void PrintStats()
    {
        int totalCalories = calorieslist.Sum(); 
        Console.WriteLine($"Namn: {name}|Typ: {type} | Hunger: {hunger} | Boredom: {boredom}  Ordförråd: {words.Count} ord | Kalorier: {totalCalories} | Kalorier kvar: {playerCalories}"  );
    }

    public bool GetAlive()
    {
        return isAlive;
    }
    

    
    private void ReduceBoredom()
    {
        Console.WriteLine($"[{name}] är nu mindre uttråkad");
        boredom -= 2;

        if (boredom < 0)
        {
            boredom = 0;
        }
    }






}
