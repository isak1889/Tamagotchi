using System;

public class BoredTama: Tamagotchi
{
    public BoredTama()
    {
        //definerar vilken typ tamagotchin är
        TamaType="Bored Tamagotchi";
    }
    public override void Tick()
    {
        hunger ++;
        //boredom ökar med ett slumpmässigt tal mellan 1 och 4
        boredom += Random.Shared.Next(1,4);
        PlayerCalories += CaloriesPerRound;

        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }
}
