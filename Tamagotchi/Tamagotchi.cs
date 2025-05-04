using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


public class Tamagotchi
{
    protected int hunger;

    protected int boredom;

    private List<string> words = new List<string>() {"Hello"};

    protected bool isAlive;

    public string name;

      public Tamagotchi()
    {
        isAlive = true;
    }

    public void feed(int calories)
    {
        Console.WriteLine ($"[{name}] äter och blir mindre hungrig");
        //hunger -= Random.Shared.Next(0,3);
        hunger -= Math.Max(calories,0);

        //if (hunger < 0)
       // {
        //    hunger = 0;
        //}
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
        Console.WriteLine($"Namn: {name} | Hunger: {hunger} | Boredom: {boredom}  Ordförråd: {words.Count} ord " );
    }

    public bool GetAlive()
    {
        return isAlive;
    }
    

    
    private void ReduceBoredom()
    {
        Console.WriteLine($"[{name}] är nu mindre uttråkad");
        boredom -= 2;

        if (boredom > 0)
        {
            boredom = 0;
        }
    }






}
