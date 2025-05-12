using System;

public class BoredTama: Tamagotchi
{
    public BoredTama()
    {
        //definerar vilken typ tamagotchin är
        type="Bored Tamagotchi";
    }
    public override void tick()
    {
        hunger ++;
        //boredom ökar med ett slumpmässigt tal mellan 1 och 4
        boredom += Random.Shared.Next(1,4);
        playerCalories += caloriesPerRound;

        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }
}
