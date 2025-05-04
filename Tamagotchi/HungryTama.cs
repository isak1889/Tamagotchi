using System;

public class HungryTama: Tamagotchi
{

    public HungryTama()
    {
        type = "Hungry Tamagotchi";
    }
    public override void tick()
    {
        hunger +=Random.Shared.Next(0,4);
        boredom ++;

        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }
}
