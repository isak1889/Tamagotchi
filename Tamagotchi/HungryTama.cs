using System;

public class HungryTama: Tamagotchi
{

    public HungryTama()
    {
        //definerar vilken typ tamagotchin är
        TamaType = "Hungry Tamagotchi";
    }
    public override void Tick()
    {
        //hungern ökar med ett slumpmässigt tal mellan 0 och 4
        hunger +=Random.Shared.Next(0,4);
        boredom ++;
        PlayerCalories += CaloriesPerRound;

        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }
}
